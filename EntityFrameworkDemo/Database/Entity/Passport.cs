using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Database.Entity
{
    public class Passport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Series { get; set; }

        [Required]
        public int Number { get; set; }

        public Passport(int series, int number) 
        {
            Series = series;
            Number = number;
        }
    }
}
