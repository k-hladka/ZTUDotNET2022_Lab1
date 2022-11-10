using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ForNetCore.Classes
{
    public class Violin : MusicalInstrument
    {
        public Violin()
        {
            Name = "Скрипка";
            Price = 4980;
        }
        public Violin(string name):this()
        {
            Name = name;
        }
        public Violin(string name, int price) : this(name)
        {
            Price = price;
        }

        public override void Sound()
        {
            Console.WriteLine("Звук скрипки");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний iнструмент: {Name}");
        }
        public override void Decs()
        {
            Console.WriteLine("СКРИПКА - смичковий музичний iнструмент iз чотирма струнами.\n");
        }
        public override void History()
        {
            Console.WriteLine("СКРИПКА: Прототипами скрипки були арабський ребаб i нiмецька рота, злиття яких i утворило вiолу.\n" +
                "Форми скрипки сформувались до XVI столiття, в цьому столiттi i на початку наступного, творили майстри скрипок сiмейства Аматi. " +
                "Скрипка була сольним iнструментом у XVII столiттi. Першими творами для скрипки вважаються:\n" +
                "'Romanesca per violino solo є basso' Марiнi з Брешiї (1620) i 'Capriccio stravagante' його" +
                " сучасника Фарiна.\n");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Цiна {Name} = {Price}");
        }
    }
}
