using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Entities
{
    #region Mapping by Convention || by Fluent APIs
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion

    #region Mapping By Data Annotation
    //[Table("Departments", Schema = "dbo")]
    //public class Department
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [StringLength(20)]
    //    public string Name { get; set; }
    //}
    #endregion
}
