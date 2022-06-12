using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosedPrincipal
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            using (var f = new PointForm(CardNoTextBox.Text))
            {
                f.ShowDialog();
            }
        }
    }
}
