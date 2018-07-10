using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        private int x;
        private int y;
        private bool alive;

        public Cell (int _x, int _y, bool _alive)
        {
            x = _x;
            y = _y;
            alive = _alive;
        }

        public void SetLife(bool _alive)
        {
            alive = _alive;
        }
        public bool IsAlive()
        {
            return alive;
        }

        public void SetX(int _x)
        {
            x = _x;
        }
        public int GetX()
        {
            return x;
        }

        public void SetY(int _y)
        {
            y = _y;
        }
        public int GetY()
        {
            return y;
        }

        public int[] Top()
        {
            if (y == 0)
            {
                return new int[2] { x, 199 };
            }
            else
            {
                return new int[2] { x, y - 1 };
            }
        }

        public int[] Bottom()
        {
            if (y == 199)
            {
                return new int[2] { x, 0 };
            }
            else
            {
                return new int[2] { x, y + 1 };
            }
        }

        public int[] Left()
        {
            if (x == 0)
            {
                return new int[2] { 199, y };
            }
            else
            {
                return new int[2] { x - 1, y };
            }
        }

        public int[] Right()
        {
            if (x == 199)
            {
                return new int[2] { 0, y };
            }
            else
            {
                return new int[2] { x + 1, y };
            }
        }

        public int[] TopLeft()
        {
            if (y == 0)
            {
                if (x == 0)
                {
                    return new int[2] { 199, 199 };
                }
                else
                {
                    return new int[2] { x - 1, 199 };
                }
            }
            else
            {
                if (x == 0)
                {
                    return new int[2] { 199, y - 1 };
                }
                else
                {
                    return new int[2] { x - 1, y - 1 };
                }
            }
        }

        public int[] TopRight()
        {
            if (y == 0)
            {
                if (x == 199)
                {
                    return new int[2] { 0, 199 };
                }
                else
                {
                    return new int[2] { x + 1, 199 };
                }
            }
            else
            {
                if (x == 199)
                {
                    return new int[2] { 0, y - 1 };
                }
                else
                {
                    return new int[2] { x + 1, y - 1 };
                }
            }
        }

        public int[] BottomLeft()
        {
            if (y == 199)
            {
                if (x == 0)
                {
                    return new int[2] { 199, 0 };
                }
                else
                {
                    return new int[2] { x - 1, 0 };
                }
            }
            else
            {
                if (x == 0)
                {
                    return new int[2] { 199, y + 1 };
                }
                else
                {
                    return new int[2] { x - 1, y + 1 };
                }
            }
        }

        public int[] BottomRight()
        {
            if (y == 199)
            {
                if (x == 199)
                {
                    return new int[2] { 0, 0 };
                }
                else
                {
                    return new int[2] { x + 1, 0 };
                }
            }
            else
            {
                if (x == 199)
                {
                    return new int[2] { 0, y + 1 };
                }
                else
                {
                    return new int[2] { x + 1, y + 1 };
                }
            }
        }


    }
}
