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
    public partial class clubpage : UserControl
    {
        private static clubpage _instance;

        public static clubpage Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new clubpage();
                }
                return _instance;
            }
        }
        public clubpage()
        {
            InitializeComponent();
        }
    }
}

