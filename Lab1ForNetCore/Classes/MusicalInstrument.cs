using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ForNetCore.Classes
{
    public abstract class MusicalInstrument
    {
        public string Name { get; set; } = "";
        public int Price { get; set; }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Decs();
        public abstract void History();
        public abstract void ShowInfo();
        public object Clone() => MemberwiseClone();
    }
}
