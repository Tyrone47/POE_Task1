using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y , 10 , 1 ,"G")
        {
            this.random = new Random();
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            move = (MovementEnum)random.Next(Convert.ToInt32(characterVision [0, 3]));
            if(characterVision == characterVision)
            {
                random.Next(Convert.ToInt32(characterVision[0, 3]));
            }
            

            return (MovementEnum)random.Next(Convert.ToInt32(characterVision[0, 3]));
        }
    }
}
