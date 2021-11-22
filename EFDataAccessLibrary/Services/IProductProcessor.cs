using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;

namespace EFDataAccessLibrary.Services
{
    public interface IProductProcessor
    {
        Product ValidateProduct(Product product);
    }
}