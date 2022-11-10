using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ForNetCore.Classes
{
    public class Trombone : MusicalInstrument
    {
        public Trombone()
        {
            Name = "Тромбон";
            Price = 9880;
        }
        public Trombone(string name):this()
        {
            Name = name;
        }
        public Trombone(string name, int price) : this(name)
        {
            Price = price;
        }
        public override void Sound()
        {
            Console.WriteLine("Звук тромбона");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний iнструмент: {Name}");
        }
        public override void Decs()
        {
            Console.WriteLine("ТРОМБОН - музичний iнструмент сiмейства мiдних духових, який володiє прекрасним, насиченим тембром.\n" +
               "Часто використовується в духових оркестрах або виступає в якостi солюючого iнструменту.\n");
        }
        public override void History()
        {
            Console.WriteLine("ТРОМБОН: Першi iнструменти, якi представляли собою тромбони, називалися сакбутамi.\n" +
                "Вони були менше сучасних iнструментiв за розмiром i мали менше рiзновидiв по регiстрах.\n" +
                "Сакбути завдяки хроматичного звукоряду вiдразу стали постiйними членами оркестрiв.\n" +
                "Невеликi удосконалення сакбутов привели до появи в XVII столiттi сучасних тромбонiв.\n");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Цiна {Name} = {Price}");
        }
    }
}
