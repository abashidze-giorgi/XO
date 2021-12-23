using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class UC_Board_Squad : UserControl
    {
        public UC_Board_Squad()
        {
            InitializeComponent();
        }

        private void lbl_text_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private string TEXT;

        public string _text
        {
            get { return TEXT; }
            set { TEXT = value; lbl_text.Text = value; }
        }

        private Color Color;

        public Color _color
        {
            get { return Color; }
            set { Color = value; this.BackColor = value; }
        }



        private void UC_Board_Squad_Click(object sender, EventArgs e)
        {

        }
    }
}
