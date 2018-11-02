using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majig.service
{
    public class DooIt : IDooIt
    {
        public int getIt(int num) {
            return num * 2;
        }
    }
}
