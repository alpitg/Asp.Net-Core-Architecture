using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.DataAccess.DbEntities
{
    public partial class EmployeeAttendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long EmployeeAttendanceId { get; set; }
        public long? EmployeeDetailId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string TotalWorkTime { get; set; }

        [ForeignKey("EmployeeDetailId")]
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
