using System;
using System.Windows.Forms;

namespace SampleSorter
{
    public partial class NameDialog : Form
    {
        public string name {
            get { return tbName.Text; }
        }
        public NameDialog() {
            InitializeComponent();
        }

        public NameDialog(string prevName) {
            InitializeComponent();
            tbName.Text = prevName;
        }
    }
}
