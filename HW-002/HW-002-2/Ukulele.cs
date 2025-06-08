using System;
using System.Runtime.InteropServices;

namespace HW_002_2
{
    internal class Ukulele : MusicaInstrument
    {
        public Ukulele(string name, string description, string historyInfo) : base(name, description, historyInfo) { }

        public override void Sound(string sound)
        {
            Console.WriteLine($"Sound of {Name}: {sound}");
        }
    }
}
