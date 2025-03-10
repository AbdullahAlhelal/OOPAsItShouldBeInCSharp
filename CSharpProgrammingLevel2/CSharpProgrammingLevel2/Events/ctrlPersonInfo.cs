using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class ctrlPersonInfo : UserControl
    {

        public event Action<string> OnPrint;

        protected virtual void Printed(string FullName)
        {
           Action<string> action = OnPrint;
            if (action != null)
                OnPrint(FullName);

        }
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            if ( OnPrint != null )
                OnPrint(textBox1.Text + textBox2.Text);
        }
    }
}
