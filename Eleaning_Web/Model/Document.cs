using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_ELEANING.Model
{
    public class Document
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }
        public string NameDocument { get; set; }
        public string Link { get; set; }
        public int SubjectId { get; set; }
        public Subject subject { get; set; }
    }
}
