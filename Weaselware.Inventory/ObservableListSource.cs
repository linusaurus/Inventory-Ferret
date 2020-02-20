using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Weaselware.InventoryFerret
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
            where T : class
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
