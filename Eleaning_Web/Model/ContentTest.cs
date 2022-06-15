using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Eleaning_Web.Model
{
    public class ContentTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentId { get; set; }
        public string Content { get; set; }
        public int Result { get; set; }
        public int IdTest { get; set; }
        public Test test  { get; set; }

    }
}
