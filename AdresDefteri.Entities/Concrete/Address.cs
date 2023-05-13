using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri.Entities.Concrete
{
    [Table("Addresses")]
    public class Address : BaseEntity
    {
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public bool IsDraft { get; set; }
        public int LikeCount { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual List<Liked> Likes { get; set; }

        public Address() 
        { 
            Likes = new List<Liked>();
        }
    }
}
