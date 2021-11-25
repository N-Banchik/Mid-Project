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
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        IEmployeeRepository employee { get; }
        IItemsRepository items { get; }
        IordersRepository orders { get; }
        IShiftsRepository shifts { get; }

        Task CompleteAsync();
        
    }
}
