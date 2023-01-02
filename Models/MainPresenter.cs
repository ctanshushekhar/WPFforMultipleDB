using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFforMultipleDB.ViewModels;

namespace WPFforMultipleDB.Models
{
    public class MainPresenter : Presenter
    {
        //public ObservableCollection<ItemPresenter> Items { get; } = new ObservableCollection<ItemPresenter>
        //{
        //    new ItemPresenter("A"),
        //    new ItemPresenter("B"),
        //    new ItemPresenter("C"),
        //    new ItemPresenter("D")
        //};

        private ObservableCollection<ItemPresenter> _items;

        public ObservableCollection<ItemPresenter> Items
        {
            get { return _items; }
            set 
            { 
                _items = value;
                RaisePropertyChanged("Items");
            }
        }

        public MainPresenter()
        {
            Items = new ObservableCollection<ItemPresenter>();
            Items.Add(new ItemPresenter("A"));
            Items.Add(new ItemPresenter("B"));
            Items.Add(new ItemPresenter("C"));
            Items.Add(new ItemPresenter("D"));
            Items.Add(new ItemPresenter("E"));


        }
        public ICommand DoStuffCommand => new Command(param =>
        {

            string abc = null;
            foreach (var item in Items)
            {
                item.IsSelected = true;
            }
        }
        );



        //public ICommand DoStuffCommand { get; set; }

    }
}
