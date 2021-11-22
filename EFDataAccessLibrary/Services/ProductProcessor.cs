using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Services
{
    public class ProductProcessor : IProductProcessor
    {

        /// <summary>
        /// Sample of a Service to use with DI
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Product ValidateProduct(Product product)
        {
            try
            {
                bool valid = false;
                if (product == null)
                    throw new NullReferenceException("Product object is null");

                valid = string.IsNullOrWhiteSpace(product.Category) ? throw new ArgumentException("Product Category not specified") : true;
                valid = string.IsNullOrWhiteSpace(product.Name) ? throw new ArgumentException("Product Name not specified") : true;
                valid = (product.Price < 1) ? throw new ArgumentException("Product Price is invalid") : true;

                return valid ? product : throw new AggregateException("Invalid Product Object"); ;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
