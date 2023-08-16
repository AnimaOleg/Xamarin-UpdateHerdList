using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UpdateHerdList
{
    //public partial class MainPage : ContentPage
    //{
    //    public MainPage()
    //    {
    //        InitializeComponent();
    //    }
    //}


    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Herd> HerdsThatsNeedsToBeUpdated { get; set; }
        public ICommand UpdateThisHerdCommand { get; set; }
        public MainPage()
        {
            InitializeComponent();

            HerdsThatsNeedsToBeUpdated = new ObservableCollection<Herd>()
        {
            new Herd(){HeaderName="test 1"},
            new Herd(){HeaderName="test 2"},
            new Herd(){HeaderName="test 3"},
            new Herd(){HeaderName="test 4"},
            new Herd(){HeaderName="test 5"},
            new Herd(){HeaderName="test 6"}

        };

            UpdateThisHerdCommand = new Command<Herd>(checkboxcommand);

            this.BindingContext = this;
        }

        private void checkboxcommand(Herd herd)
        {
            Console.WriteLine("the selected item is {0}", herd.HeaderName);
        }
    }

    public class Herd
    {
        public string HeaderName { get; set; }
    }
}
