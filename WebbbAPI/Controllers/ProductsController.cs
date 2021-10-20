using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Bu class bir Controllerdir, ayağını denk al! gevgev
    public class ProductsController : ControllerBase
       
    {
        //Loosely coupled
        //naming convention
        //IoC Container -- Inversion of Control = ihtiyaç kutusu, içinde sahibinden 1. el referansalar oluşturur bellek üzerinde.
        IProductService _productService;

        public ProductsController(IProductService productService) //bu şekilde constructor ile newleme gerçekleşmez bu yüzden IoC üzerinden referans alınır
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
           
            
              IProductService productservice = new ProductManager(new EfProductDal());
                var result = productservice.GetAll();
                return result.Data;

            

        }
    }
}
