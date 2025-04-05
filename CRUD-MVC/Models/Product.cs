using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }





    }
}
