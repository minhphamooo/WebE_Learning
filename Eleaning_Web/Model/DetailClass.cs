using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WEB_ELEANING.Model
{
    public class DetailClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailClassId { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}
