using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_ELEANING.Model
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string NameClass { get; set; }
        public string Link { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public List<DetailSubject> DetailSubject { get; set; }
        public List<DetailClass> DetailClass { get; set; }
        
        
    }
}
