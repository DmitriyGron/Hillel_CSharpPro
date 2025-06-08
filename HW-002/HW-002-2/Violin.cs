using System;

namespace HW_002_2
{
    internal class Violin : MusicaInstrument
    {
        public Violin(string name, string description, string historyInfo) : base(name, description, historyInfo) { }

        public override void Sound(string sound)
        {
            Console.WriteLine($"Sound of {Name}: {sound}");
        }
    }
}
