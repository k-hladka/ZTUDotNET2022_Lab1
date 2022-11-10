using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ForNetCore.Classes
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele()
        {
            Name = "Укулеле";
            Price = 6000;
        }
        public Ukulele(string name):this()
        {
            Name = name;
        }
        public Ukulele(string name, int price) : this(name)
        {
            Price = price;
        }
        public override void Sound()
        {
            Console.WriteLine("Звук укулеле");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний iнструмент: {Name}");
        }
        public override void Decs()
        {
            Console.WriteLine("УКУЛЕЛЕ - невеликий чотириструнний музичний iнструмент iнструмент," +
                " що схожий на гiтару.\n");
        }
        public override void History()
        {
            Console.WriteLine("УКУЛЕЛЕ: Першi прообрази укулеле з'явилися в серединi 15 столiття.\n" +
                "Сама назва 'укулеле' з'явилaсь на Гаваях, i у перекладi з гавайського це 'стрибаюча блоха'.\n" +
                "Виробляти iнструмент почали на мiсцi, з гавайської акацiї — коа, яку на островi вважали символом Гаваїв.\n" +
                "Своє поширення i популярнiсть укулеле отримали пiсля гастролей гавайських музик на Тихоокеанськiй виставцi 1915 року.\n");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Цiна {Name} = {Price}");
        }
    }
}