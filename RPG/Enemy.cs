using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Enemy
    {

        internal class Builder
        {
            public string name;
            public int max_hp;
            public int xp;
            public int attackInterval;
            public int attackStrength;
            public Image image;
            public Image attackImage;

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
            public Builder WithImage(Image image)
            {
                this.image = image;
                return this;
            }
            public Builder WithAttackImage(Image attackImage)
            {
                this.attackImage = attackImage;
                return this;
            }
            public Builder WithAttackStrength(int attackStrength)
            {
                this.attackStrength = attackStrength;
                return this;
            }

            public Enemy Build()
            {
                if (this.Validate())
                    return new Enemy(this);
                else
                    throw new NullReferenceException();

            }
            private bool Validate()
            {
                if (name == null) return false;
                if (max_hp == 0) return false;
                if (image == null) return false;
                if (attackInterval == 0) return false;
                return true;
            }
        }//end internal class
        private Enemy(Builder builder)
        {
            Name = builder.name;
            Max_HP = HP = builder.max_hp;
            XP = builder.xp;
            AttackInterval = builder.attackInterval;
            AttackStrength = builder.attackStrength;
            Items = new List<Item>();

        }
        public String Name { get; set; }
        public int Max_HP { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public int AttackInterval { get; set; }
        public double AttackStrength { get; set; }
        public Image Image { get; set; }
        public List<Item> Items { get; set; }
    }
}
