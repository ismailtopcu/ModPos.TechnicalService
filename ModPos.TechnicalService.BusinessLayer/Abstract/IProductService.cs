using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        Task<List<ResultProductDto>> TGetProductList();
        Task<ResultProductDto> TGetProductById(int id);
    }
}
