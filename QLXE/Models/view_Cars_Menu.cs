﻿
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLXE.Models
{
    [Table("view_Cars_Menu")]
    public class view_Cars_Menu
    {
        [Key]
        public long CarId { get; set; }
        public string? CarName { get; set; }
        public string? CarType { get; set; }
        public string? CarImage { get; set; }
        public int MenuID { get; set; }
        public string? Price { get; set; }
        public string? CarColor { get; set; }
        public string? ManuFacturer { get; set; }
        public string? EngineType { get; set; }
        public int Status { get; set; }
        public DateTime? ManufactureYear { get; set; }
        public int SeatingCapacity { get; set; }
        public bool? IsActive { get; set; }
        public string? MenuName { get; set; }
    }
}
