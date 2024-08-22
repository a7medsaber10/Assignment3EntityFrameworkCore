using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Entities
{
    #region mapping by convention
    //public class Topic
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    #endregion

    #region Mapping By Data Annotation
    [Table("Topics", Schema = "dbo")]
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
    #endregion
}
