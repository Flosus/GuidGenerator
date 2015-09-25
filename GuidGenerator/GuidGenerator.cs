using System;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class GuidGenerator : Form
    {
        public GuidGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txbGuids.Clear();
            for (int i = 0; i < Counter.Value; i++)
            {
                txbGuids.Text += Guid.NewGuid().ToString() + Environment.NewLine;
            }
        }
    }
}
