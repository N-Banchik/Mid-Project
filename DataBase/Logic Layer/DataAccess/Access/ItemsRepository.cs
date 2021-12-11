using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
    public class ItemsRepository : GenericDataRepository<Items>, IItemsRepository
    {
        public ItemsRepository(DbContext context) : base(context)
        {

        }



        public async Task AddNewItemAsync(string name, Categories category, Brands brand, double Wight, int Unitsinv, int unitsmin, double price)
        {
            try
            {
                Items add = new Items { Item_Name = name, Category = category, Brand = brand, Weight = Wight, Units_In_Inventory = Unitsinv, Minimum_Units_In_Inventory = unitsmin, Price = price };
                if (await dbSet.FirstOrDefaultAsync(i => i.Item_Name == add.Item_Name) == null)
                {

                    await base.Add(add);
                }
                else { throw new Exception("Item already exists"); }
            }
            catch (Exception)
            {

                throw new Exception("Cannot add item");
            }

        }

        public async Task<ICollection<Items>> GetItemsInstockAsync()
        {
            try
            {

                return await GetByCondition(i => i.Units_In_Inventory > 0);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<ICollection<Items>> GetItemsToOrderAsync()
        {
            try
            {
                //                select*
                //from Items i
                //where i.[Item Id] not in (select i.[Item Id]
                //from Items i
                //left
                //join EIs e
                //on i.[Item Id] = e.Item_Id
                //left
                //join EDIs es
                //on e.EDI_Id = es.EDI_Id
                //where es.Approved_By is null )


                List<Items> itms = await dbSet.FromSqlRaw("select * from Items i where i.[Item Id] not in (select i.[Item Id] from Items i join EIs e on i.[Item Id]=e.Item_Id join EDIs es on e.EDI_Id = es.EDI_Id where i.[Units In inventory]<i.[Minimum Units In inventory] and es.Approved_By is null )").ToListAsync();





                    return itms /*GetByCondition(i => i.Units_In_Inventory < i.Minimum_Units_In_Inventory)*/;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateInventoryAsync(int itemid, int unitstoadd)
        {
            try
            {
                Items update = await GetById(itemid);
                update.Units_In_Inventory += unitstoadd;
                await base.Upsert(update);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
