using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<ResultProductDto>> GetProductList();
        Task<ResultProductDto> GetProductById(int id);
    }
    
}
