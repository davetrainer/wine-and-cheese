using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAndCheese.Interfaces
{
    public interface IRepository<T>
    {

        #region Constants

        #endregion

        #region Constructors

        #endregion

        #region Events & Delegates

        #endregion

        #region Properties

        #endregion

        #region Methods

        IEnumerable<T> GetAll();
        T GetById(int id);

        #endregion
    }
}
