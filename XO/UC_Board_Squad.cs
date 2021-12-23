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
            SetEmpty();
        }

        private void SetEmpty()
        {
            _isEmpty = true;
        }


        private bool IsEmpty;

        public bool _isEmpty
        {
            get { return IsEmpty; }
            set { IsEmpty = value; }
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
            set { Color = value; this.BackColor = value; SetFontColor(); }
        }

        private void SetFontColor()
        {
            if (_color == Color.Black)
            {
                lbl_text.ForeColor = Color.White;
            }
            else
            {
                lbl_text.ForeColor = Color.Black;
            }
        }
    }
}
