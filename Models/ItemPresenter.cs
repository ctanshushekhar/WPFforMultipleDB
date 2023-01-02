using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFforMultipleDB.ViewModels;

namespace WPFforMultipleDB.Models
{
    public class ItemPresenter : Presenter
    {
        private readonly string _value;
        public ItemPresenter(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

    }
}
