﻿using System;
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
        // This old code 
        //public event Action<string> OnPrint;

        //protected virtual void Printed(string FullName)
        //{
        //   Action<string> action = OnPrint;
        //    if (action != null)
        //        OnPrint(FullName);

        //}

        public class OnPrintEventArgs : EventArgs
        {
            string Firstname{ set; get; }
            string Secondname{ set; get; }
            public OnPrintEventArgs(string Firstname, string Secondname)
            {
                 this.Firstname = Firstname;
                 this.Secondname = Secondname;
            }
        }

        public EventHandler<OnPrintEventArgs> OnPrinted;

        public void OnPrintComplte(string Firstname , string Secondname)
        {
            RaisePrintComplte(new OnPrintEventArgs(Firstname, Secondname));
        }

        public virtual void RaisePrintComplte(OnPrintEventArgs e)
        {
            OnPrinted.Invoke(this,e);
        }

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            if ( OnPrinted != null )
                OnPrintComplte(textBox1.Text , textBox2.Text);
        }
    }
}
