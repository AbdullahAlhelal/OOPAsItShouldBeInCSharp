using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            lblresult.Text = Convert.ToString( Convert.ToInt32( textBox1.Text) + Convert.ToInt32(textBox2.Text));
        }
    }
}
