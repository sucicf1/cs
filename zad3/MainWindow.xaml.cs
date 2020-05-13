using System.Windows;
using zad3.ViewModel;

namespace zad3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Item[] items = new Item[3];
        public MainWindow()
        {
            InitializeComponent();
            Car car = new Car();
            items[0] = car;
            car.Id = 1; car.Name = "Toyota"; car.Type = "SUV"; car.Color = "red";

            House house = new House();
            items[1] = house;
            house.Id = 2; house.Name = "saloon"; house.IsFlatRoof = true; house.NumberOfFloors = 5;

            Person person = new Person();
            items[2] = person;
            person.Id = 3; person.Name = "Jesse James"; person.Address = "wild west boulevard 3"; person.Age = 20;

            ((MainViewModel)DataContext).Items = items;
        }
    }
}
