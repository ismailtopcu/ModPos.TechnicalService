using ModPos.TechnicalService.BusinessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task TDeleteAsync(Category t)
        {
           await _categoryDal.DeleteAsync(t);
        }

        public async Task<Category> TGetByIdAsync(int id)
        {
            return await _categoryDal.GetByIdAsync(id);
        }

        public async Task<List<Category>> TGetListAsync()
        {
            return await _categoryDal.GetListAsync();
        }

        public async Task TInsertAsync(Category t)
        {
            await _categoryDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Category t)
        {
            await _categoryDal.UpdateAsync(t);
        }
    }
}
