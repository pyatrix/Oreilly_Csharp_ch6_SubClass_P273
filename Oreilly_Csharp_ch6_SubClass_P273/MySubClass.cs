using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch6_SubClass_P273
{
    class MySubClass:MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
