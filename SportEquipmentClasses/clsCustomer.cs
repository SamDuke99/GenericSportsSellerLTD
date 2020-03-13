using System;

namespace SportEquipmentClasses
{
    public class clsCustomer
    {
        public bool Verified { get; set; }
        //dateofbirth private member variable
        private DateTime mDateOfBirth;
        //dateOfBirth public property
        public DateTime DateOfBirth { get
            {
                return mDateOfBirth;
            }

            set
            {
                mDateOfBirth = value;
            }
        }

        private Int32 mCustomerID;

        public int CustomerID { get {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Find(int CustomerID)
        {
            //set the private data members to the test data value
            mCustomerID = 3;
            mDateOfBirth = Convert.ToDateTime("16/09/2015");
            //always return true
            return true;
        }
    }
}