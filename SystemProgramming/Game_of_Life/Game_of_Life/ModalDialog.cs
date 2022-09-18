using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }

        public int universeSize
        {
            get { return (int)numericUniverse.Value; }
            set { numericUniverse.Value = value; }
        }

        public int Miliseconds
        {
            get { return (int)numericMiliseconds.Value; }
            set { numericMiliseconds.Value = value; }
        }
    }
}
