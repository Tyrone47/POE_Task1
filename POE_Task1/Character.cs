using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
     abstract class Character : Tile
    {
        public Character(int x, int y) : base(x, y) { }

        protected int HP { get;set; }
        protected int maxHP { get; set; }
        protected int damage { get; set; }



    }
}
