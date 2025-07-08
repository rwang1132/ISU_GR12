using System.Data.Entity;

namespace ISU_Website
{
    [Serializable]
    public class Bird
    {
        //Setters and getters (built in) for bird object (OOP)
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
    }
    //Database constructor
    public class BirdsDBContext : DbContext
    {
        public DbSet<Bird>? Birds { get; set; }
    }
}