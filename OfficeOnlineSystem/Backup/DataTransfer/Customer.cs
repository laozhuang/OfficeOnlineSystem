using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransfer
{
    public class Customer
    {
        #region Fields

        private int _customerId;

        private string _firstname;

        private string _lastname;

        #endregion

        #region Properties

        public virtual int CustomerId
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
            }
        }

        public virtual string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
            }
        }

        public virtual string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
            }
        }

        #endregion

    }
}
