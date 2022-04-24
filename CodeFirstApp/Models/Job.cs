using System.ComponentModel.DataAnnotations;

namespace CodeFirstApp.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
