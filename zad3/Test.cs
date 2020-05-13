using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using zad3.ViewModel;

namespace zad3
{
    public class Test
    {
        static Item[] items = new Item[3];
        static MainViewModel mainViewModel = new MainViewModel();
        static Test()
        {
            Car car = new Car();
            items[0] = car;
            car.Id = 1; car.Name = "Toyota"; car.Type = "SUV"; car.Color = "red";

            House house = new House();
            items[1] = house;
            house.Id = 2; house.Name = "saloon"; house.IsFlatRoof = true; house.NumberOfFloors = 5;
            mainViewModel.Items = items;
        }
        [Theory]
        [MemberData(nameof(Data))]
        public void testMainView(MainViewModel view, string exp1, string exp2)
        {
            Assert.Equal(view.VisCar, exp1);
            Assert.Equal(view.VisHouse, exp2);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { mainViewModel, "Visible", "Hidden" },
        };
    }
}
