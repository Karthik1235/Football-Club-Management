using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Management
{
    public partial class coach : UserControl
    {
        private static coach _instance;

        public static coach Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new coach();
                }
                return _instance;
            }
        }
        public coach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
