using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
    }
    public abstract class Tile
    {
         protected int X { get; set; }
         protected int Y { get; set; }

        protected string symbol { get; set; }
        

        public Tile(int xAxis, int yAxis)
        {
            this.X = xAxis;
            this.Y = yAxis;
            this.symbol = "";
        }
        
    }
}
