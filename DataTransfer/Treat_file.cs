using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransfer
{
    public class Treat_file
    {
        public virtual int id { get; set; }
        
        public virtual string title { get; set; }
        public virtual string content { get; set; }
        public virtual int status { get; set; }
        public virtual string username { get; set; }
    }
}
