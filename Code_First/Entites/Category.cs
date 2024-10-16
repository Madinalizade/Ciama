using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Entites
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public virtual ICollection<Product> Products { get; set; }
    }
}
