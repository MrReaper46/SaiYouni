using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------

    public EnemyAbstract FindEnemyWithLowestHealth(List<EnemyAbstract> enemies)
    {
        if (enemies == null || enemies.Count == 0)
        {
            return null;
        }
        EnemyAbstract minHpEnemy = enemies[0];
        foreach (EnemyAbstract enemy in enemies)
        {
            if (enemy.GetHP() < minHpEnemy.GetHP())
            {
                minHpEnemy = enemy;
            }
        }
        return minHpEnemy;
    }

    public EnemyAbstract FindEnemyWithHighestHealth(List<EnemyAbstract> enemies)
    {
        if (enemies == null || enemies.Count == 0)
        {
            return null;
        }
        EnemyAbstract maxHpEnemy = enemies[0];
        foreach (EnemyAbstract enemy in enemies)
        {
            if (enemy.GetHP() > maxHpEnemy.GetHP())
            {
                maxHpEnemy = enemy;
            }
        }
        return maxHpEnemy;
    }

    //----------------------Edit above here --------------------
}
