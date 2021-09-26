using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    class Map
    {
        private Tile[,] tileMap;
        string hero = "H";

        Enemy[,] enemyArray;

        private int minWidth;

        private int minHeight;

        private int maxWidth;

        private int maxHeight;

        public int MinWidth
        {
            get { return minWidth; }
            set { minWidth = value; }
        }
        public int MaxWidth
        {
            get { return maxWidth; }
            set { maxWidth = value; }
        }
        public int MinHeight
        {
            get { return maxWidth; }
            set { maxWidth = value; }
        }
        public int MaxHeight
        {
            get { return maxWidth; }
            set { maxWidth = value; }
        }



        public Map( int minWidth , int maxWidth, int minHeight , int maxHeight , int numOfEnemies)
        {

        }
    }
}
