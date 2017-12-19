using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
        public class Character
    {
        
        internal class Builder
        {
            public string name;
            public int max_hp;
            public int xp;
            public int attackInterval;
            public string imagePath;
            public Builder Character()
            {
                return new Builder();
            }
            public Builder Named(string name)
            {
                this.name = name;
                return this;
            }
            public Builder WithMaxHP(int max_hp)
            {
                this.max_hp = max_hp;
                return this;
            }
            public Builder WithXP(int xp)
            {
                this.xp = xp;
                return this;
            }
            public Builder WithAttackInterval(int attackInterval)
            {
                this.attackInterval = attackInterval;
                return this;
            }
            public Builder WithImagePath(string imagePath)
            {
                this.imagePath = imagePath;
                return this;
            }
            public Character Build()
            {
                if (this.Validate())
                    return new Character(this);
                else
                    throw new NullReferenceException();
               
            }
            private bool Validate()
            {
                if (name == null) return false;
                if (max_hp == 0) return false;
                if (imagePath == null) return false;
                if (attackInterval == 0) return false;
                return true;
            }
        }//end internal Builder class
        private Character() { Items = new List<Item>(); }
        private Character(Builder builder)
        {
            Name = builder.name;
            Max_HP = HP = builder.max_hp;
            XP = builder.xp;
            AttackInterval = builder.attackInterval;
            ImagePath = builder.imagePath;
            Items = new List<Item>();
        }
        public String Name { get; set; }
        public int Max_HP { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public int AttackInterval { get; set; }
        public string ImagePath { get; set; }
        public List<Item> Items { get; set; }
    }
}
