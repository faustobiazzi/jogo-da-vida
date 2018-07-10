using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Board
    {
        public Cell[,] board = new Cell[200, 200];

        public Cell GetCellAt(int x, int y)
        {
            return board[x, y];
        }

        public void NewRandomBoard()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int x = 0; x < 200; x++)
            {
                for (int y = 0; y < 200; y++)
                {
                    if (random.Next() % 2 == 0)
                    {
                        board[x, y] = new Cell(x, y, true);
                    }
                    else
                    {
                        board[x, y] = new Cell(x, y, false);
                    }
                }
            }
        }

        public void NextBoard()
        {
            Cell[,] newBoard = new Cell[200, 200];
            for (int x = 0; x < 200; x++)
            {
                for (int y = 0; y < 200; y++)
                {
                    Cell cell = this.GetCellAt(x, y);
                    int rule = 0;
                    if (this.GetCellAt(cell.Top()[0], cell.Top()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.Bottom()[0], cell.Bottom()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.Left()[0], cell.Left()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.Right()[0], cell.Right()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.TopRight()[0], cell.TopRight()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.TopLeft()[0], cell.TopLeft()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.BottomRight()[0], cell.BottomRight()[1]).IsAlive())
                    {
                        rule++;
                    }
                    if (this.GetCellAt(cell.BottomLeft()[0], cell.BottomLeft()[1]).IsAlive())
                    {
                        rule++;
                    }

                    switch(rule)
                    {
                        case 0:
                        case 1:
                            {
                                newBoard[x, y] = new Cell(x, y, false);
                                break;
                            }
                        case 2:
                            {
                                if (cell.IsAlive())
                                {
                                    newBoard[x, y] = new Cell(x, y, true);
                                }
                                else
                                {
                                    newBoard[x, y] = new Cell(x, y, false);
                                }
                                break;
                            }
                        case 3:
                            {
                                newBoard[x, y] = new Cell(x, y, true);
                                break;
                            }
                        default:
                            {
                                newBoard[x, y] = new Cell(x, y, false);
                                break;
                            }
                    }
                }
            }
            board = newBoard;
        }

    }
}
