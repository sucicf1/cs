using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Linq;

namespace zad3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private Item[] items;
        private int currentItem = 0;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            OnPreviousClickedCommand = new RelayCommand(OnPreviousClickedHandler);
            OnNextClickedCommand = new RelayCommand(OnNextClickedHandler);
        }

        public Item[] Items
        {
            get { return items; }
            set
            {
                currentItem = 0;
                items = value;
                RaisePropertyChanged(string.Empty);
            }
        }
        public int Id
        {
            get { if (items != null) return items[currentItem].Id; else return 0; }
        }

        public string Name
        {
            get { if (items != null) return items[currentItem].Name; else return string.Empty; }
        }

        public string Type
        {
            get
            {
                if (items != null && items[currentItem] is Car)
                {
                    return ((Car)items[currentItem]).Type;
                }
                else
                    return "";
            }
        }

        public string Color
        {
            get
            {
                if (items != null && items[currentItem] is Car)
                {
                    return ((Car)items[currentItem]).Color;
                }
                else
                    return "";
            }
        }

        public string IsFlatRoof
        {
            get
            {
                if (items != null && items[currentItem] is House)
                {
                    return ((House)items[currentItem]).IsFlatRoof.ToString();
                }
                else
                    return "false";
            }
        }

        public int NumberOfFloors
        {
            get
            {
                if (items != null && items[currentItem] is House)
                {
                    return ((House)items[currentItem]).NumberOfFloors;
                }
                else
                    return 0;
            }
        }

        public string Address
        {
            get
            {
                if (items != null && items[currentItem] is Person)
                {
                    return ((Person)items[currentItem]).Address;
                }
                else
                    return "";
            }
        }

        public int Age
        {
            get
            {
                if (items != null && items[currentItem] is Person)
                {
                    return ((Person)items[currentItem]).Age;
                }
                else
                    return 0;
            }
        }

        public string VisCar
        {
            get
            {
                if (items != null && items[currentItem] is Car)
                    return "Visible";
                else
                    return "Hidden";
            }
        }

        public string VisHouse
        {
            get
            {
                if (items != null && items[currentItem] is House)
                    return "Visible";
                else
                    return "Hidden";
            }
        }

        public string VisPerson
        {
            get
            {
                if (items != null && items[currentItem] is Person)
                    return "Visible";
                else
                    return "Hidden";
            }
        }

        public RelayCommand OnPreviousClickedCommand { get; private set; }
        public RelayCommand OnNextClickedCommand { get; private set; }
        private void OnPreviousClickedHandler()
        {
            if (items != null)
            {
                currentItem = (currentItem - 1) % items.Count();
                currentItem = currentItem < 0 ? currentItem + items.Count() : currentItem;
                RaisePropertyChanged(string.Empty);
            }
        }

        private void OnNextClickedHandler()
        {
            if (items != null)
            {
                currentItem = (currentItem + 1) % items.Count();
                RaisePropertyChanged(string.Empty);
            }
        }
    }
}