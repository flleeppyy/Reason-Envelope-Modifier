using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvelopeModifier.Modules;

namespace EnvelopeModifier
{
    public partial class EnvelopeWindow : Form
    {
        public EnvelopeWindow()
        {
            InitializeComponent();
        }

        private void OpenRepatch(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked thing", "holy crap you click button", MessageBoxButtons.YesNo);
            //UserDialogs.SelectFile("" +"*.repatch", ""); // This causes an error, dunno why
        }
    }
}
