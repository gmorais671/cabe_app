using System.ComponentModel.DataAnnotations.Schema;

namespace cabe_API.Models
{
    [Table("contacts")]
    public class Contact
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("phone")]
        public string Phone { get; set; } = string.Empty;

        [Column("latitude")]
        public decimal Latitude { get; set; } = 0;

        [Column("longitude")]
        public decimal Longitude { get; set; } = 0;

        [Column("type")]
        public int Type { get; set; }

        [Column("favorite")]
        public int Favorite { get; set; }
    }
}
