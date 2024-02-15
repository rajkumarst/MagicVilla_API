namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Occupancy { get; set; }
        public int SqFt { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
