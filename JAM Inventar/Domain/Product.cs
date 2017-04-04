using System;
using System.Collections.Generic;

namespace JAM_Inventar.Domain
{
    public class Product
    {
        
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual Int32 StartAmount { get; set; }
        public virtual IList<Modification> Modifications { get; set; }
        public virtual Location Location { get; set; }
        public virtual String Unit { get; set; }
        
    }
}
