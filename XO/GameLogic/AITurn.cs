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
        List<UC_Board_Squad> Boards;

        List<UC_Board_Squad> playerBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> AIBoards = new List<UC_Board_Squad>();

        List<UC_Board_Squad> emptyBoards = new List<UC_Board_Squad>();

        List<Array> winnerLines = new List<Array>();

        List<Array> playerWarningLines = new List<Array>();

        List<Array> AIWarningLines = new List<Array>();

        List< UC_Board_Squad> AISelectboardList = new List<UC_Board_Squad>();

        int AILevel = 0;

        private void AI_Turn()
        {
            AISelectboardList.Clear();
            if (Boards[4]._isEmpty)
            {
                if (AILevel != 2)
                {
                    Random rng = new Random();
                    bool randomBool = rng.Next(0, 2) > 0;
                    if (!randomBool)
                    {
                        AISelectboardList.Add(Boards[4]);
                        return;
                    }
                }
                else
                {
                    AISelectboardList.Add(Boards[4]);
                    return;
                }
            }
            CheckAIWarningLines();
        }

        private void CheckAIWarningLines()
        {
            if(AIWarningLines.Count > 0)
            {
                UC_Board_Squad board = new UC_Board_Squad();
                int currentLineOccupiedBoard = 0;
                foreach (var winnerArray in AIWarningLines)
                {
                    foreach (int boardIndex in winnerArray)
                    {
                        if (Boards[boardIndex-1]._ocupated == "AI")
                        {
                            currentLineOccupiedBoard++;
                        }
                        else if(Boards[boardIndex - 1]._ocupated != "player" && Boards[boardIndex - 1]._isEmpty)
                        {
                            AISelectboardList.Add(Boards[boardIndex - 1]);
                        }
                        else if(Boards[boardIndex - 1]._isEmpty)
                        {
                            board = Boards[boardIndex - 1];
                            AISelectboardList.Add(board);
                        }
                    }
                    if(currentLineOccupiedBoard > 2)
                    {
                        if (board._isEmpty)
                        {
                            AISelectboardList.Clear();
                            AISelectboardList.Add(board);
                            return;
                        }
                    }
                }
            }
            CheckPlayerWarningLines();
        }

        private void CheckPlayerWarningLines()
        {
            if (playerWarningLines.Count > 0)
            {
                UC_Board_Squad board = new UC_Board_Squad();
                int occupiedBoards = 0;
                foreach (var winnerArray in playerWarningLines)
                {
                    foreach (int boardIndex in winnerArray)
                    {
                    }
                }
            }
        }

 
        public List<UC_Board_Squad> AI_Selected_Boards(List<UC_Board_Squad> list, int aiLevel)
        {
            AILevel = aiLevel;
            Boards = list;
            SetWinnerLines();
            foreach (UC_Board_Squad uc in Boards)
            {
                Check_Player_Turns(uc);
            }
            CheckWarningLines();
            AnalysResult();
            AI_Turn();
            return AISelectboardList;
        }

        private void SetWinnerLines()
        {
            if(winnerLines.Count == 0)
            {
                int[] array1 = new int[] { 1, 4, 7 };
                int[] array2 = new int[] { 2, 5, 8 };
                int[] array3 = new int[] { 3, 6, 9 };
                int[] array4 = new int[] { 1, 2, 3 };
                int[] array5 = new int[] { 4, 5, 6 };
                int[] array6 = new int[] { 7, 8, 9 };
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
