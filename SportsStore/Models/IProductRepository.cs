using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
   public interface IProductRepository
    {
        //iqueryable instead of ineumariable coz IQuery is more optimized and better 
        //used to query list of our products
        IQueryable<Product> Products { get; }
    }
}
