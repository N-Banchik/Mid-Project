using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IunitOfWork_Costumer :IAsyncDisposable
    {
        IAddressCostumerRepository addressCostumer { get;  }
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        ICostumerRepository costumer { get; }
        IItemsRepository items { get; }
        IorderRepository orders { get; }
        IorderItemsRepository orderitems { get; }

        Task CompleteAsync();
        
    }
}
