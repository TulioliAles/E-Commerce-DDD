using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices
{
    public interface IServiceProduct
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
