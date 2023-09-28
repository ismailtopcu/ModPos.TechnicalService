using ModPos.TechnicalService.DataAccessLayer.Abstract;
using ModPos.TechnicalService.DataAccessLayer.Concrete;
using ModPos.TechnicalService.DataAccessLayer.Repositories;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.DataAccessLayer.EntityFramework
{
    public class EfServiceMovementsDal : GenericRepository<ServiceMovements>, IServiceMovementsDal
    {
        public EfServiceMovementsDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
