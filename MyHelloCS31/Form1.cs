using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelloCS31
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하신가? 밥은 먹었나?", 
                "나님이 말씀하시길..", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
