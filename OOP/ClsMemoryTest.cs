using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClsMemoryTest
    {
        //instance class var 每個物件建立一份
        //public int count=0;

        public static int count;//statc 共享,只有一份
        public ClsMemoryTest()
        {
            count++;
        }
        ~ClsMemoryTest()
        {
            count--;
        }
    }
}
