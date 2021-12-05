using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Context;

namespace Logic_Layer.DataAccess.Access
{
   public  class UnitOfWork_Costumer: IunitOfWork_Costumer
    {
        private readonly DbContext context;

        public UnitOfWork_Costumer()
        {
            
            this.context = new FactoryDbContext();
            this.brands = new BrandsRepository(context);
            this.category = new CategoryRepository(context);
            this.items = new ItemsRepository(context);
            this.costumer = new CostumerRepository(context);
            this.addressCostumer = new AddressCostumerRepository(context);
        }

        public IAddressCostumerRepository addressCostumer { get; private set; }
        public IBrandsRepository brands { get; private set; }
        public ICategoryRepository category { get; private set; }
        public ICostumerRepository costumer { get; private set; }
        public IItemsRepository items { get; private set; }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
        
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync();
        }
    }
}
