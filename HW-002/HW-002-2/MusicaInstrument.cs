using System;

namespace HW_002_2
{
    internal class MusicaInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string HistoryInfo { get; set; }

        public MusicaInstrument(string name, string description, string historyInfo )
        {
            Name = name;
            Description = description;
            HistoryInfo = historyInfo;
        }

        public void Show()
        {
            Console.WriteLine($"Musical Instrument: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description of {Name}: {Description}");
        }

        public void History()
        {
            Console.WriteLine($"History of {Name}: {HistoryInfo}.");
        }

        public virtual void Sound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
