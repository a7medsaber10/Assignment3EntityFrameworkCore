using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3EntityFrameworkCore.Entities
{
    #region mapping by convention
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    } 
    #endregion
}
