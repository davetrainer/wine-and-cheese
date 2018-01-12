using WineAndCheese.Interfaces;
using WineAndCheese.Repositories;

namespace WineAndCheese.Model.Services
{
    public class WineService
    {
        #region Constants

        #endregion

        #region Constructors

        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public WineService() : this(new WineRepository())
        {
        }

        #endregion

        #region Events & Delegates

        #endregion

        #region Properties

        private IWineRepository _wineRepository { get; set; }
        #endregion

        #region Methods

        public DomainObjects.Wine GetById(int id)
        {
            var entity = _wineRepository.GetById(id);

            return new DomainObjects.Wine()
            {
                Id = entity.Id,
                Name = entity.Name,
                GraoeId = entity.GrapeId,
                CountryId = entity.CountryId
            };
        }

        #endregion
    }
}
