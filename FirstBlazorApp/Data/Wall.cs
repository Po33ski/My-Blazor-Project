using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data



{
    public class Wall
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters")]
        public string NameW { get; set; }


        public float ThickW { get; set; }
        public float LambdaW { get; set; }

        public List<Layout> layouts = new();


        public float FactorRW
        {
            get; set;

        }
    }
}
