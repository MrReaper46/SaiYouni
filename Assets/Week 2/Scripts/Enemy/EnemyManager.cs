using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    List<EnemyAbstract> enemies = new List<EnemyAbstract>();
    EnemyAbstract minHPEnemy;
    EnemyAbstract maxHPEnemy;
    FindEnemy findEnemy;

    private void Start()
    {
        findEnemy = this.gameObject.AddComponent<FindEnemy>();
        this.LoadEnemy();
        this.ShowEnemy();
        minHPEnemy = findEnemy.FindEnemyWithLowestHealth(enemies);
        Debug.Log($"LowestHpEnemy: {minHPEnemy.name} -  HP: {minHPEnemy.GetHP()}");
        maxHPEnemy = findEnemy.FindEnemyWithHighestHealth(enemies);
        Debug.Log($"HighestHpEnemy: {maxHPEnemy.name} -  HP: {maxHPEnemy.GetHP()}");
    }
    protected void LoadEnemy()
    {
        foreach (Transform child in transform)
        {
            EnemyAbstract enemy = child.GetComponent<EnemyAbstract>();
            this.enemies.Add(enemy);
        }
    }
    protected void ShowEnemy()
    {
        foreach (EnemyAbstract enemy in this.enemies)
        {
            Debug.Log($"Enemy:{enemy.name} / HP: {enemy.GetHP()} / isDead: {enemy.IsDead()}");
        }
    }
}
