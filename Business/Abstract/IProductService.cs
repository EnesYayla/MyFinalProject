using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); //hem işlem sonucunu
                                             //hem mesajı
                                             //hem de döndüreceği şeyi içeren(List<Product> gibi) bir yapı görevi görür
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //Buralardaki IDataResult ile amaç yukarıda yazılan şeyleri ekleyip bu metodların potansiyelini artırmaktır
        IResult Add(Product product); //void görevi görür

                                      //Restful --> HTTP Protokolü (Bir kaynağa ulaşmak için izlenilen yol) --> Restful Network'e HTTP ile bağlanır HTTPS (Giriş izni anlamına gelir)
                                      //Controller bizim uygulammamızı kullanmak istedikleri şeyleri yazığımız klasör, bir şey yaptırtma klasörü, amele klasör

    }
}
