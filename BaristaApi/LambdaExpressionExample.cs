using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class Car
    {
        public string Color { get; set; }

        public bool IsColor(Func<string, bool> lambda_IsColor)
        {
            return lambda_IsColor(Color);
        }
    }

    public static class CreateCars
    {
        public static void Init()
        {
            var carA = new Car { Color = "red" };
            var carB = new Car { Color = "green" };

            Console.WriteLine(carA.IsColor(color => color == "red"));
            Console.WriteLine(carA.IsColor(color => color == "green"));

            Console.WriteLine(carB.IsColor(color => color == "red"));
            Console.WriteLine(carB.IsColor(color => color == "green"));
        }
    }
}
