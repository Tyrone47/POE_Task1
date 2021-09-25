using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    public abstract class Enemy : Character
    {
        protected Random random;

        public Enemy(int x , int y , int damage, int maxHP , string symbol) : base(x, y, symbol )
        {
           
        }
        public override string ToString()
        {
            return typeof(Enemy).Name + " at[ " + this.X + "," + this.Y + "] (Amount + " + this.damage + ")";
        }
    }
}
