using ApplicationApp.Interfaces;
using Domain.Interface.InterfaceProduct;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : IProductApp
    {
        private readonly IProduct _iProduct;
        private readonly IServiceProduct _iServiceProduct;

        public AppProduct(IProduct iProduct, IServiceProduct iServiceProduct)
        {
            _iProduct = iProduct;
            _iServiceProduct = iServiceProduct;
        }

        public async Task AddProduct(Product product)
        {
            await _iServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _iServiceProduct.UpdateProduct(product);
        }

        public async Task Add(Product Objeto)
        {
            await _iProduct.Add(Objeto);
        }

        public async Task Update(Product Objeto)
        {
            await _iProduct.Update(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _iProduct.Delete(Objeto);
        }
        public async Task<Product> GetEntityById(int Id)
        {
            return await _iProduct.GetEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _iProduct.List();
        }
    }
}
