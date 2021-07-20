using Domain.Interface.InterfaceProduct;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _iProduct;

        public ServiceProduct(IProduct iProduct)
        {
            _iProduct = iProduct;
        }

        public async Task AddProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadesString(product.Nome, "Nome");

            var validaValor = product.ValorPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            {
                product.Estado = true;
                await _iProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validaNome = product.ValidarPropriedadesString(product.Nome, "Nome");

            var validaValor = product.ValorPropriedadeDecimal(product.Valor, "Valor");

            if(validaNome && validaValor)
            {
                await _iProduct.Update(product);
            }
        }
    }
}
