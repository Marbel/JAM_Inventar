using System;

namespace JAM_Inventar.Domain
{
    public class Modification
    {

        public virtual int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Amount { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual String User { get; set; }
        public virtual String Use { get; set; }
        public virtual String Comment { get; set; }

    }
}
