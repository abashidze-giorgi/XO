using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XO;

namespace XO.GameLogic
{
    internal class AITurn
    {
        List<UC_Board_Squad> Boards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> playerBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> AIBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> emptyBoards = new List<UC_Board_Squad>();

        List<Array> winnerLines = new List<Array>();

        List<Array> playerWarningLines = new List<Array>();

        List<Array> AIWarningLines = new List<Array>();

        UC_Board_Squad AISelectboard;

        private void AI_Turn()
        {
            if (Boards[4]._isEmpty)
            {
                Form1 form = new Form1();
                AISelectboard = Boards[4];
            }
        }

        private void CheckAIWarningLines()
        {

        }

        private void CheckPlayerWarningLines()
        {

        }

 
        public UC_Board_Squad Ai_Turn(List<UC_Board_Squad> list)
        {
            Boards = list;
            SetWinnerLines();
            foreach (UC_Board_Squad uc in list)
            {
                Check_Player_Turns(uc);
            }
            CheckWarningLines();
            AnalysResult();
            AI_Turn();
            return AISelectboard;
        }

        private void SetWinnerLines()
        {
            if(winnerLines.Count == 0)
            {
                int[] array1 = new int[] { 1, 2, 3 };
                int[] array2 = new int[] { 4, 5, 6 };
                int[] array3 = new int[] { 7, 8, 9 };
                int[] array4 = new int[] { 1, 4, 7 };
                int[] array5 = new int[] { 2, 5, 8 };
                int[] array6 = new int[] { 3, 6, 9 };
                int[] array7 = new int[] { 1, 5, 9 };
                int[] array8 = new int[] { 3, 5, 7 };
                winnerLines.Add(array1);
                winnerLines.Add(array2);
                winnerLines.Add(array3);
                winnerLines.Add(array4);
                winnerLines.Add(array5);
                winnerLines.Add(array6);
                winnerLines.Add(array7);
                winnerLines.Add(array8);
            }
        }

        private void CheckWarningLines()
        {
            AIWarningLines.Clear();
            playerWarningLines.Clear();
            foreach (var winnerBoardsArray in winnerLines)
            {
                int playerBoard = 0;
                int AIBoard = 0;
                int emptyBoard = 0;
                foreach(int boardIndex in winnerBoardsArray)
                {
                    UC_Board_Squad board = Boards[boardIndex-1];
                    string occupated = board._ocupated;
                    switch (occupated)
                    {
                        case "player":
                            playerBoard++;
                            break;
                        case "AI":
                            AIBoard++;
                            break;
                        default:
                            emptyBoard++;
                            break;
                    }
                }
                if (playerBoard > 2 || playerBoard > AIBoard)
                {
                    playerWarningLines.Add(winnerBoardsArray);
                }
                else if (AIBoard > 2 || AIBoard > playerBoard)
                {
                    AIWarningLines.Add(winnerBoardsArray);
                }
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

        private void AnalysResult()
        {

        }

    }
}
