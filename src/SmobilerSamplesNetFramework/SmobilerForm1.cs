using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamplesNetFramework
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
#if NETCOREAPP3_0
            MessageBox.Show("Hello .NetCore World!");
#else
            MessageBox.Show("Hello World!");
#endif
        }
    }
}