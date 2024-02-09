using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Facade
{

    internal class DifficultManager
    {
        Player player = new Player();
        Settings settings = new Settings();

        public void SetHardDifficult()
        {
            player.SetPlayerHp(1);
            player.SetViewRange(50f);

            settings.SetLimitedLight(true);
            settings.SetImmortalEnemies(true);
        }
        public void SetEasyDifficult()
        {
            player.SetPlayerHp(1);
            player.SetViewRange(50f);

            settings.SetLimitedLight(false);
            settings.SetImmortalEnemies(false);
        }

        public void ShowNewDifficultChanges()
        {
            Console.WriteLine($"Player hp: {player.hp}");
            Console.WriteLine($"Player view range: {player.viewRange}");

            Console.WriteLine($"Immortal enemies: {settings.immortalEnemies}");
            Console.WriteLine($"Limited light: {settings.limitedLight}");
        }

    }
}
