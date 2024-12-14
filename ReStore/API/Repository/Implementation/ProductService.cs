using API.Data;
using API.Entities;
using API.Helper;
using API.Helper.Constants;
using API.Models;
using API.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Implementation
{
    public class ProductService : IProductService
    {
        private readonly StoreContext _storeContext;
        public ProductService(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public Task<ResponseVM> Add(ProductVM model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseVM> Delete(int id)
        {
            throw new NotImplementedException();
        }
/// <summary>
/// 
/// </summary>
/// <returns></returns>
        public async Task<ResponseVM> Get()
        {
            try
            {
                var productList=await _storeContext.Products.ToListAsync();
                return ResponseVM.Success(MessageConstants.Success,productList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ResponseVM.InternalServerError(MessageConstants.Error);
            }
        }

        public async Task<ResponseVM> Get(int id)
        {
           try
            {
                Product product=await _storeContext.Products.FirstOrDefaultAsync(x=>x.Id==id);
                if(product is null) ResponseVM.NoContentFound(MessageConstants.NoDataFound);

                return ResponseVM.Success(MessageConstants.Success,product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ResponseVM.InternalServerError(MessageConstants.Error);
            }
        }

        public Task<ResponseVM> Update(int id, ProductVM model)
        {
            throw new NotImplementedException();
        }
    }
}