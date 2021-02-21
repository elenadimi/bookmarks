using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLater.Entities
{
    public class Bookmark : EntityBase  
    {
        [Key]
        public int ID { get; set; }

        [StringLength(maximumLength: 500)]
        [DisplayName("Bookmark URL")]
        public string URL {get;set;}

        [DisplayName("Short description")]
        public string ShortDescription { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
