using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    class Hero : Character
    {
        
        public Hero(int x, int y, int hP, string symbol) : base(x, y,symbol )
        {
            
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NOMOVEMENT)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return " Player Stats: " + "\n" +
                " HP: " + this.HP + "/" + this.maxHP + "\n " +
                "[" + this.X + ", " + this.Y + "]";
        }

    }
}
