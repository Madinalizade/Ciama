using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Entites
{
    public class BaseEntity
    {
        public int Id {  get; set; }
        public bool IsDeleted { get; set; }
    }
}
