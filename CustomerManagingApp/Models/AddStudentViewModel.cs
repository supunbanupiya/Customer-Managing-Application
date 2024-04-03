using System.ComponentModel.DataAnnotations;

namespace CustomerManagingApp.Models
{
    public class AddStudentViewModel
    {
        public Guid Id { get; set; }

   /*     [Required(ErrorMessage ="Could not be Null")]
        [StringLength(100,ErrorMessage="At least 10 Numbers")]*/
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }

    }
}
