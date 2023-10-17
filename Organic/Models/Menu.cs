using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Organic.Models
{
    [Table("dbo.tb_Menu")]
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string? Title { get; set; }
        public string? Alias { get; set; }
        public string? Decription { get; set; }
        public int Levels { get; set; }
        public int ParentId { get; set; }
        public int Position { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

    }
}