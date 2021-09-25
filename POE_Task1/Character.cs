using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
     abstract class Character : Tile
    {
        

        protected int HP { get;set; }
        protected int maxHP { get; set; }
        protected int damage { get; set; }

        protected int[,] characterVision;

        public enum MovementEnum
        {
            NOMOVEMENT,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        public Character (int xPos , int yPos) : base(xPos, yPos) { }

        public virtual void Attack(Character target)
        {

        }

        public bool isDead ()
        {
            return false;
        
        }

        public virtual bool CheckRange(Character target)
        {

        }

        private int distanceTo(Character target)
        {

        }
        public void Move(MovementEnum move)
        {

        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0)
        {

        }
        public abstract override string ToString();

    }
}
