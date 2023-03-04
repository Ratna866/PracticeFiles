using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace PracticeWebApi.Model
{
    public class EmployeeTBL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; } = default!;
        [StringLength(150)]
        public string LastName { get; set; } = default!;
        [StringLength(250)]
        public string Email{ get; set; } = default!;

        public int Age{ get; set; }
        public DateTime Doj { get; set; }
        [StringLength(20)]
        public string gender { get; set; } = default!;
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationId { get; set; }
        [NotMapped]
        public string Designation { get; set; } = default!;

    }
}
