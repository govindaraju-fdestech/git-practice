using System.ComponentModel.DataAnnotations;

namespace PracticeSignalR.Models
{
    public class ImageUploadModel
    {
        [Required]
        [Display(Name = "Image File")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Selfie")]
        public bool IsSelfie { get; set; }

        [Display(Name = "Crop Area")]
        public string CropArea { get; set; }
    }
}
