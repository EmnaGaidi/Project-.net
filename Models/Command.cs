using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Command
    {
        List<Product> products_list;
        public Command() {
            products_list = new List<Product>();
        }
        public void addProduct(Product product)
        {
            products_list.Add(product);
        }
        public void deleteProduct(Product product)
        {
            products_list.Remove(product);
        }
        public void sommeCommand()
        {
            for(int i=0;i<products_list.Count;i++)
            {
                this.somme += products_list[i].price;
            }
        }
        public int Id { get; set; }
        [Key]
        public int Id_user  { get; set; }
        [Key]
        public int quantite { get; set; }
        public float somme { get; set; }
    }
}
