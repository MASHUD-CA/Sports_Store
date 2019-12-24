using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository; // As we need to use list of product
    
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        // List of products will be sent to our first view our list view
        // It tells MVC to give/render view for action method. 
        // Passing the collection of product objects from the repository to View method
        // provides the framework with the data with which to populate the Model object
        //in a strongly typed view.

        public ViewResult List() => View(repository.Products);

    }
}
