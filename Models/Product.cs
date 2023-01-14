using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Product
    {
        public Product(int Id, string name, string release_date, string description,string type, float price, string singer, string img, string genre) { 
            this.Id = Id;
            this.name= name;
            this.description = description;
            this.type = type;
            this.price = price;
            this.singer = singer;
            this.description = description;
            this.release_date = release_date;
            this.img= img;
            this.genre = genre;
        }
        public int Id { get; set; }
        [Key]
        public string name { get; set; }
        public string release_date { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public float price { get; set; }
        public string singer { get; set; }
        public string img { get; set; }
        public string genre { get; set; } 
    }
}
