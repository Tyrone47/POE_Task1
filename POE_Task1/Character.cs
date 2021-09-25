using System;
using System.Collections.Generic;
using System.Text;

namespace POE_Task1
{
    public enum MovementEnum
    {
        NOMOVEMENT,
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    public abstract class Character : Tile
    {


        protected int HP;
        protected int maxHP;
        protected int damage;

        public int GetHP()
        {
            return HP;

        }
        public void SetHP(int hP)
        {
            this.HP = hP;
        }
        public int GetMaxHP()
        {
            return HP;

        }

        public void SetMaxHP(int maxiHp)
        {
            this.maxHP = maxiHp;

        }
        public int GetDamage()
        {
            return damage;

        }
        public void SetDamage(int damage)
        {
            this.damage = damage;

        }


        protected Tile[,] characterVision;

        

        public Character (int xPos , int yPos , string symbol) : base(xPos, yPos) { this.symbol = symbol; }

        public virtual void Attack(Character target) { }
        

        public bool isDead ()
        {
            
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            return false;//To implement

        }

        private int DistanceTo(Character target)
        {
            return 0;//To implement
        }
        public void Move(MovementEnum move)
        {
            if (move == MovementEnum.UP)
            {
                this.Y++;
            }
            else if(move == MovementEnum.DOWN)
            {
                this.Y--;
            }
            else if(move == MovementEnum.LEFT)
            {
                this.X--;

            }
            else if(move == MovementEnum.RIGHT)
            {
                this.X++;
            }
            
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);
        

        
        public abstract override string ToString();

    }
}
