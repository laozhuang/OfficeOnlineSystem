using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransfer
{

    public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
    }


}
