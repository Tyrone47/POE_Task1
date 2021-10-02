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

            MovementEnum movement = MovementEnum.NOMOVEMENT;//Initialise Movement to be NOMOVEMENT by default
            EmptyTile empty = new EmptyTile(0, 0);

            bool notFoundMovement = true;

            do
            {
                    movement = (MovementEnum)random.Next(0, 5);
                if (movement == MovementEnum.UP && this.characterVision[this.X, this.Y + 1].Equals(empty))
                {
                    notFoundMovement = false;
                    
                }
                else if (movement == MovementEnum.DOWN && this.characterVision[this.X, this.Y - 1 ].Equals(empty))
                {
                    notFoundMovement = false;
                    
                }
                else if (movement == MovementEnum.LEFT && this.characterVision[this.X - 1, this.Y].Equals(empty))
                {
                    notFoundMovement = false;
                    
                }
                else if (movement == MovementEnum.RIGHT && this.characterVision[this.X + 1, this.Y].Equals(empty))
                {
                    notFoundMovement = false;
                    
                }
            } while (notFoundMovement);
           

            return movement;
             
        }
    }
}
