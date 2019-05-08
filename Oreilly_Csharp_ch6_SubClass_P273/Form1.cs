using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch6_SubClass_P273
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string AAA = "AAAAAA";
            MyBaseClass baseA = new MyBaseClass(AAA);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string BBB = "BBBBBB";
            int CCC = 123;
            MySubClass baseB = new MySubClass(BBB,CCC);
        }
    }
}
