using System;
using System.Xml.Linq;

namespace HW_002_2
{
    internal class Trombone : MusicaInstrument
    {
        public Trombone(string name, string description, string historyInfo) : base(name, description, historyInfo) { }


        public override void Sound(string sound)
        {
            Console.WriteLine($"Sound of {Name}: {sound}");
        }
    }
}