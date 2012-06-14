using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataTransfer
{
    public class User 
    {
        public virtual string username { get; set; }
        public virtual string password { get; set; }
        public virtual string email { get; set; }
        public virtual int office_id { get; set; }
        public virtual int role { get; set; }
    }
}
