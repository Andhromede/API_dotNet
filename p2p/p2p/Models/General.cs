using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace p2p.Models
{
    public class GeneralItem
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public bool is_active { get; set; }
    }

}
