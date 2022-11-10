using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ForNetCore.Classes
{
    public class Cello : MusicalInstrument
    {
        public Cello()
        {
            Name = "Вiолончель";
            Price = 75900;
        }
        public Cello(string name):this()
        {
            Name = name;
        }
        public Cello(string name, int price) : this(name)
        {
            Price = price;
        }
        public override void Sound()
        {
            Console.WriteLine("Звук вiолончелi");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний iнструмент: {Name}");
        }
        public override void Decs()
        {
            Console.WriteLine("ВIОЛОНЧЕЛЬ - струнний смичковий музичний iнструмент.\n");
        }
        public override void History()
        {
            Console.WriteLine("ВIОЛОНЧЕЛЬ: Поява вiолончелi вiдноситься до початку XVI столiття.\n" +
                "Спочатку вiолончель використовували як басовий iнструмент, яким супроводжували спiв\n" +
                "або акомпанували за допомогою неї iнструменти високого регiстру.\n" +
                "Було багато рiзних видiв вiолончелей, якi рiзнилися за розмiром та кiлькiстю струн.\n");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Цiна {Name} = {Price}");
        }
    }
}
