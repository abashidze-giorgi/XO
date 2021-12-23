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
    public partial class Form1 : Form
    {
        Properties.Settings settings = new Properties.Settings();

        Color tableColor = new Color();

        bool symbolX = true;

        int UiLevel;

        int gameLevel = 0;

        bool PlayerTurn = false;

        List<UC_Board_Squad> boards = new List<UC_Board_Squad>();

        public Form1()
        {
            InitializeComponent();
            tableColor = settings._boardColor;
            GetUserControls();
            setColors();
            Get_Level();
        }
        private void GetUserControls()
        {
            tableLayoutPanel1.Controls.Clear();
            int a = tableLayoutPanel1.RowCount;
            int b = tableLayoutPanel1.ColumnCount;
            int boardIndex = 1;
            for(int i = 0; i < a; i++)
            {
                for(int x = 0; x < b; x++)
                {
                    UC_Board_Squad uc = new UC_Board_Squad();
                    uc._color = tableColor;
                    uc.Name = boardIndex.ToString();
                    boardIndex++;
                    uc._text = "";
                    uc.Dock = DockStyle.Fill;
                    uc.tlp.Click += (s, e) => { Set_Text("", uc); };
                    boards.Add(uc);
                    tableLayoutPanel1.Controls.Add(uc, i, x);
                }
            }
        }
        private void Set_Text(string v, UC_Board_Squad uc)
        {
            uc._text = Get_Symbol();
        }
        private string Get_Symbol()
        {
            string text = "X";
            if (!symbolX)
            {
                text = "O";
            }
            symbolX = !symbolX;
            return text;
        }
        private void ChooseColor()
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tableColor = colorDialog1.Color;
                settings._boardColor = colorDialog1.Color;
                settings.Save();
            }
            setColors();
            GetUserControls();
        }
        private void setColors()
        {
            
            btn_boardColor.BackColor = tableColor;
            if(btn_boardColor.BackColor == Color.Black)
            {
                btn_boardColor.ForeColor = Color.White;
            }
            else
            {
                btn_boardColor.ForeColor = Color.Black;
            }
        }
        private void btn_boardColor_Click(object sender, EventArgs e)
        {
            ChooseColor();
        }

       private void Set_Level()
        {

        }
        private void Get_Level()
        {
            UiLevel = settings._level;
        }
    }
}
