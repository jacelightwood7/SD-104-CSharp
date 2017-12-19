using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class EnemyGenerator
    {

        List<Enemy> Enemies = new List<Enemy>()
        {
            //level 1
            new Enemy.Builder().Named("Jelly Bean").WithMaxHP(400).WithXP(135).WithAttackInterval(8000).WithAttackStrength(250).WithImage(Properties.Resources.jelly_bean).Build(),
              new Enemy.Builder().Named("Buffalo Bill").WithMaxHP(666).WithXP(145).WithAttackInterval(8000).WithAttackStrength(350).WithImage(Properties.Resources.Buffalo_Bill).Build(),
                new Enemy.Builder().Named("Old Biff").WithMaxHP(1000).WithXP(150).WithAttackInterval(7800).WithAttackStrength(450).WithImage(Properties.Resources.old_biff).Build(),
                  new Enemy.Builder().Named("The Nihilists").WithMaxHP(1000).WithXP(135).WithAttackInterval(8000).WithAttackStrength(400).WithImage(Properties.Resources.nihilists).Build(),
                    new Enemy.Builder().Named("Young Biff").WithMaxHP(1200).WithXP(160).WithAttackInterval(7600).WithAttackStrength(600).WithImage(Properties.Resources.young_biff).Build(),
                      new Enemy.Builder().Named("Mad Dog").WithMaxHP(1350).WithXP(165).WithAttackInterval(7600).WithAttackStrength(750).WithImage(Properties.Resources.mad_dog_tannen).Build(),
        };
        public Enemy GetRandomEnemy()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, Enemies.Count);
            return Enemies[randNum];
        }
    }
}
