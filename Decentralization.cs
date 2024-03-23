using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp
{
    internal class Decentralization
    {
        private static bool isAdmin;
        private static int  mabn;
        public void setisAdmin(bool check)
        {
            isAdmin = check;
        }
        public bool getisAdmin()
        {
            return isAdmin;
        }
        public void setmabn(int mabnn)
        {
            mabn = mabnn;
        }
        public int getmabn()
        {
            return mabn;
        }
    }
}
