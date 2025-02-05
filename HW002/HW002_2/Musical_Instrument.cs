using System;

namespace HW002_2
{
    public class Musical_Instrument
    {
        public string sound { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string history { get; set; }

        public Musical_Instrument(string name, string description, string history, string sound)
        {
            this.sound = sound;
            this.name = name;
            this.description = description;
            this.history = history;
        }

        public void Sound() => Console.WriteLine("Sound: " + sound);
        public void Show() => Console.WriteLine("Name: " + name);
        public void Desc() => Console.WriteLine("Description: " + description);
        public void History() => Console.WriteLine("History: " + history);
    }
}
