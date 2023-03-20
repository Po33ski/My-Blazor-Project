using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data

{
    public class Layout
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Valid Thick Range is (1-10000)")]
        public float Thick { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Valid Lambda Range is (1-10000)")]
        public float Lambda { get; set; }


        public float FactorR
        {
            get; set;

        }

        public void CalculateFR()
        {
            FactorR = this.Thick / this.Lambda;
        }

    }
}
