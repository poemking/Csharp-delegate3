using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_delegate3
{
    public partial class Form2 : Form
    {
        public delegate void DelegateDemo(string MyPara);
        public DelegateDemo DelegateDemoObj;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelegateDemoObj.Invoke("Message from Form2");
        }
    }
}
