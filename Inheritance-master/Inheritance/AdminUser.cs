using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class AdminUser: User
    {
        private int failedlogins;
        private bool locked;

        public int Failedlogins
        {
            get { return failedlogins; }
            set { failedlogins = value; }
        }
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        public override bool CheckPassword(string pass)
        {
            // The keyword base refers to the parent, so in our case the user class
            //return base.CheckPassword(pass);

            Boolean ret;

            if (locked == true)
            {
                return false;
            }

            ret = base.CheckPassword(pass);

            if (ret == false)
            {
                failedlogins++;
                Console.WriteLine(failedlogins);

                if (failedlogins == 3)
                {
                    locked = true;
                    Console.WriteLine("Your account has been locked" + locked);
                }
                return false;
            }
            else
            {
                failedlogins = 0;
                return true;
            }
        }
    }
}
