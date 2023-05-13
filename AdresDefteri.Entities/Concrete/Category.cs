using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri.Entities.Concrete
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        [Required, DisplayName("Kategori Adı"), StringLength(50)]
        public string Name { get; set; }
        [StringLength(200), DisplayName("Açıklama")]
        public string Description { get; set; }

        public virtual List<Address> Addresses { get; set; }

        public Category() 
        { 
            Addresses = new List<Address>();
        }
    }
}
