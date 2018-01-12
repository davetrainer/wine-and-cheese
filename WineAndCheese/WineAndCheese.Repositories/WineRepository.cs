using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineAndCheese.DataAccess.Entities;
using WineAndCheese.Interfaces;

namespace WineAndCheese.Repositories
{
    public class WineRepository : IWineRepository
    {

        #region Constants

        #endregion

        #region Constructors

        public WineRepository()
        {
            _wineList = new List<Wine>();
            _wineList.Add(new Wine() { Id = 1, Name = "Châteauneuf-du-Pape", GrapeId = 1, CountryId = 1 });
            _wineList.Add(new Wine() { Id = 2, Name = "Lorgeril Corbieres", GrapeId = 2, CountryId = 2 });
        }

        #endregion

        #region Events & Delegates

        #endregion

        #region Properties

        private List<Wine> _wineList { get; set; }

        #endregion

        #region Methods

        public IEnumerable<Wine> GetAll()
        {
            return _wineList;
        }

        public Wine GetById(int id)
        {
            return _wineList.Find(x => x.Id == id);
        }

        #endregion
    }
}
