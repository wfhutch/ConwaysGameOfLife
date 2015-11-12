﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class BoundedWorld : Board
    {
        private Cell[,] cells;
        public int Height { get; set; }
        public int Width { get; set; }
        private List<Cell> to_die;
        private List<Cell> to_live;

        public BoundedWorld() : this(10,10)  
        {
            // sets default size of world if not given by calling constructor below
        }

        public BoundedWorld(int width, int height) 
        {
            to_die = new List<Cell>();
            to_live = new List<Cell>();
            cells = new Cell[height, width];
            Width = width;
            Height = height;
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cells[row, col] = new Cell();
                }
            }
        }

        public void Tick()
        {
            foreach (var cell in to_die)
            {
                cells[cell.Y, cell.X].IsAlive = false;
            }

            foreach (var cell in to_live)
            {
                cells[cell.Y, cell.X].IsAlive = true;
            }
        }

        public List<List<bool>> ToList()
        {
            throw new NotImplementedException();
        }

        public int AliveCellCount()
        {
            return (Width * Height) - DeadCellCount();
        }

        public int DeadCellCount()
        {
            int result = 0;

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (!cells[row, col].IsAlive)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public void AddCell(int x, int y)
        {
            /* var my_cell = cell[y,x];
            my_cell.IsAlive = true;
            */
            cells[y, x].IsAlive = true;
        }

        public void UnderPopulationRule()
        {
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (AliveNeighborCount(row, col) < 2)
                    {
                        // Keep track that we should kill off this cell
                        to_die.Add(new Cell { X = row, Y = col });
                    }
                }
            }
        }

        private bool IsCellAlive(Cell c)
        {
            return c.IsAlive;
        }

        public int AliveNeighborCount(int x, int y)
        {
            return GetNeighbors(x, y).FindAll(IsCellAlive).Count;
        }

        private Cell TryGetCell(int pos_x, int pos_y)
        {
            Cell c = null;
            try
            {
                c = cells[pos_y, pos_x];
            }
            catch (IndexOutOfRangeException)
            {
                c = null;
            }
            return c;
        }

        public List<Cell> GetNeighbors(int x, int y)
        {
            Cell above, below, right, left;
            Cell top_right, top_left, bottom_left, bottom_right;
            List<Cell> neighbors = new List<Cell>();
            //neighbors.Add(above);

            above = TryGetCell(x - 1, y);
            below = TryGetCell(x + 1, y);
            right = TryGetCell(y + 1, x);
            left = TryGetCell(y - 1, x);
            top_right = TryGetCell(y + 1, x - 1);
            top_left = TryGetCell(y - 1, x - 1);
            bottom_right = TryGetCell(y + 1, x + 1);
            bottom_left = TryGetCell(y - 1, x + 1);

            neighbors.Add(above);
            neighbors.Add(below);
            neighbors.Add(right);
            neighbors.Add(left);
            neighbors.Add(top_right);
            neighbors.Add(top_left);
            neighbors.Add(bottom_right);
            neighbors.Add(bottom_left);

            return neighbors.FindAll(IsNotNull);

        }

        private bool IsNotNull(Cell obj)
        {
            return obj != null;
        }
    }
}
