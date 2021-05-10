using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProductLibrary
{
    public interface IProductService
    {

        // TODO Add [DataContract]

        // TODO Add [OperationContract]
        ProductService Find(int id);
        //List<ProductDTO> GetAll();
        //void Add(ProductDTO Product);
        //void Update(ProductDTO Product);
        //void Delete(int id);
    }
}
