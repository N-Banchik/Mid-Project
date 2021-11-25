using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Access
{
    class UnitOfWork_Costumer: IunitOfWork_Costumer
    {
        private readonly DbContext context;

        public UnitOfWork_Costumer(DbContext context)
        {
            this.context = context;
            this.brands = new BrandsRepository(context);
            this.category = new CategoryRepository(context);
            this.items = new ItemsRepository(context);
            this.costumer = new CostumerRepository(context);
            this.orders = new OrdersRepository(context);
            this.addressCostumer = new AddressCostumerRepository(context);
        }

        public IAddressCostumerRepository addressCostumer { get; private set; }
        public IBrandsRepository brands { get; private set; }
        public ICategoryRepository category { get; private set; }
        public ICostumerRepository costumer { get; private set; }
        public IItemsRepository items { get; private set; }
        public IordersRepository orders { get; private set; }


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
