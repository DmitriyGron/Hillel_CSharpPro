using System;
using System.Web;

namespace HW_002_2
{
    internal class Cello : MusicaInstrument
    {
        public Cello(string name, string description, string historyInfo) : base(name, description, historyInfo) {    }

        public override void Sound(string sound)
        {
            Console.WriteLine($"Sound of {Name}: {sound}");
        }
    }
}
