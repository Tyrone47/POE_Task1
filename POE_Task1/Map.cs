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

        private int mapWidth;

        private int mapHeight;

        private int minWidth;

        public int GetMinWidth
        {
            get { return myVar; }
            set { myVar = value; }
        }



        public Map( int minWidth , int maxWidth, int minHeight , int maxHeight , int numOfEnemies)
        {

        }
    }
}
