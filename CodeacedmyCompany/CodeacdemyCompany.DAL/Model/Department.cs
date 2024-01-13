using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeacdemyCompany.DAL.Model
{
    public class Department
    {

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepartment { get; set; }

        [Required(ErrorMessage = "Name is Required for the Department")]
        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;






    }
}
