using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.DataAccess.DbEntities
{
    public partial class EmployeeDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "serial")]
        public long EmployeeDetailId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }
}
