using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO.GameLogic;

namespace XO
{
    public partial class Form1 : Form
    {
        Properties.Settings settings = new Properties.Settings();

        AITurn aiTurn = new AITurn();

        Color tableColor = new Color();

        bool symbolX = true;

        int AILevel;

        int gameLevel = 1;

        bool playerTurn = false;

        protected List<UC_Board_Squad> boards = new List<UC_Board_Squad>();
        public Form1()
        {
            InitializeComponent();
            tableColor = settings._boardColor;
            GetUserControls();
            setColors();
            Get_AI_Level();
            SelectWhoStart();
            StartGame();
        }

        private void StartGame()
        {
            if (!playerTurn)
            {

            }
        }

        private void SelectWhoStart()
        {
            if(gameLevel == 1)
            {
                cmb_start.SelectedIndex = 0;
            }
            if(cmb_start.SelectedIndex == 0)
            {
                playerTurn = true;
            }
            else
            {
                playerTurn=false;
            }
        }

        private void GetUserControls()
        {
            boards.Clear();
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
                    uc.lbl_text.Click += (s, e) => { Set_Text("", uc); };
                    boards.Add(uc);
                    tableLayoutPanel1.Controls.Add(uc, i, x);
                }
            }
        }
        private void Set_Text(string v, UC_Board_Squad uc)
        {
            if (uc._isEmpty)
            {
                uc._text = Get_Symbol();
                if (playerTurn)
                {
                    uc._ocupated = "player";
                }
                else
                {
                    uc._ocupated = "AI";
                }
                playerTurn = !playerTurn;
                uc._isEmpty = false;
            }
            else
            {
                MessageBox.Show("უჯრა უკვე შევსებულია");
            }
            aiTurn.CheckBoards(boards);
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
        private void cmb_ai_lvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_AI_Level();
            Get_AI_Level();
        }
        private void Get_AI_Level()
        {
            AILevel = settings._level;
            cmb_ai_lvl.SelectedIndex = AILevel;
        }
        private void Set_AI_Level()
        {
            if (cmb_ai_lvl.SelectedIndex == 0)
            {
                settings._level = 0;
            }
            else
            {
                settings._level = 1;
            }
            settings.Save();
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void Restart()
        {
            symbolX = true;
            GetUserControls();
        }

        private void ChangeTurn()
        {
            playerTurn = !playerTurn;
        }

        private void Do_AI_Turn()
        {
            
        }
    }
}
