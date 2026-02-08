using System;

namespace AgenzieFormativeForm.Models
{
    public class Presenza
    {
        public int Id { get; set; }
        public int IscrizioneId { get; set; }
        public int LezioneId { get; set; }
        public int OrePresenza { get; set; }
        public TimeSpan? EntraAlle { get; set; }
        public TimeSpan? EsceAlle { get; set; }
    }
}
