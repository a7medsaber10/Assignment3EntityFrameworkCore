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
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal? Bonus { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
    }
    #endregion


    #region Mapping By Data Annotation
    //[Table("Instructors", Schema = "dbo")]
    //public class Instructor
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [StringLength(20)]
    //    [Column(TypeName = "varchar")]
    //    public string Name { get; set; }

    //    [DataType(DataType.Currency)]
    //    public decimal Salary { get; set; }

    //    [DataType(DataType.Currency)]
    //    public decimal Bonus { get; set; }

    //    [MaxLength(50)]
    //    public string? Address { get; set; }

    //    [Required]
    //    public decimal HourRate { get; set; }
    //}
    #endregion
}
