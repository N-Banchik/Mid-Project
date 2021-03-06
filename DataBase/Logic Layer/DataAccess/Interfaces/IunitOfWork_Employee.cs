using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IunitOfWork_Employee :IAsyncDisposable
    {
        IAddressEmployeeRepository addressEmployee { get; }
        IAddressCostumerRepository addressCostumer { get; }
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        IEmployeeRepository employee { get; }
        ICostumerRepository costumer { get; }
        IItemsRepository items { get; }
        IorderRepository orders { get; }
        IShiftsRepository shifts { get; }
        IorderItemsRepository orderitems { get; }



        Task CompleteAsync();
        
    }
}
