using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    List<EnemyAbstract> enemies = new();

    private void Start()
    {
        this.LoadEnemy();
        this.ShowEnemy();
    }
    protected void LoadEnemy()
    {
        foreach (Transform child in transform)
        {
            EnemyAbstract enemy = child.GetComponent<EnemyAbstract>();
            this.enemies.Add(enemy);
            Debug.Log($"child: {child.name}");
        }
    }
    protected void ShowEnemy()
    {
        foreach (EnemyAbstract enemy in this.enemies)
        {
            Debug.Log($"HP: {enemy.GetHP()} / isDead: {enemy.IsDead()}");
        }
        //Zombie zombie = new Zombie();
        //zombie.SetHP(0);
        //bool isDead = zombie.IsDead();
        //Debug.Log($"HP: {zombie.GetHP()} / isDead: {isDead}");
    }
}
