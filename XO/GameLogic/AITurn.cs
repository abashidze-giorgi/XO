using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.GameLogic
{
    internal class AITurn
    {
        List<UC_Board_Squad> boards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> playerBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> AIBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> emptyBoards = new List<UC_Board_Squad>();

        UC_Board_Squad uc = new UC_Board_Squad();
        protected void CheckBoard()
        {
            foreach(UC_Board_Squad uc in boards)
            {
                Check_Player_Turns(uc);
            }
        }

        private void Check_Player_Turns(UC_Board_Squad uc)
        {
            switch (uc._ocupated)
            {
                case "player":
                    playerBoards.Add(uc);
                    break;
                case "AI":
                    AIBoards.Add(uc);
                    break;
                default:
                    emptyBoards.Add(uc);
                    break;
            }
        }




    }
}
