using DataBase.Context;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Access
{
   public class UnitOfWork_Employee : IunitOfWork_Employee, IAsyncDisposable
    {
         readonly DbContext context;

        public UnitOfWork_Employee()
        {
            this.context = new FactoryDbContext();
            this.addressEmployee = new AddressEmployeeRepository(context);
            this.brands = new BrandsRepository(context);
            this.category = new CategoryRepository(context);
            this.employee = new EmployeeRepository(context);
            this.items = new ItemsRepository(context);
            this.shifts = new ShiftsRepository(context);
            this.costumer = new CostumerRepository(context);
            this.addressCostumer = new AddressCostumerRepository(context);
            this.EDI = new EDIRepository(context);
        }

        public IAddressEmployeeRepository addressEmployee { get; private set; }
        public IBrandsRepository brands { get; private set; }
        public ICategoryRepository category { get; private set; }
        public IEmployeeRepository employee { get; private set; }
        public IItemsRepository items { get; private set; }
        public IShiftsRepository shifts { get; private set; }
        public ICostumerRepository costumer { get; private set; }
        public IAddressCostumerRepository addressCostumer { get; private set; }
        public IEDIREpository EDI { get; private set; }

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
