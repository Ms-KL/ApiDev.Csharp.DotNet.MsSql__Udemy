namespace HelloWorld.Models{

    public class Computer
    {
        // private string _motherboard; // (creates automatically)
        public string Motherboard { get; set; }
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; }

        // Constructor
        public Computer() // can access Motheboard & VideoCard
        {
            if (Motherboard == null)
            {
                Motherboard = "";
            }
            if (VideoCard == null)
            {
                VideoCard = "";
            }
        }
    }

}
