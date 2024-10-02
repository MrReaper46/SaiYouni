using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    List<EnemyAbstract> enemies;
    private void Start()
    {
        this.LoadEnemy();
    }
    protected void LoadEnemy()
    {
        foreach (Transform child in transform)
        {
            Debug.Log($"child: {child.name}");
        }
        //Zombie zombie = new Zombie();
        //zombie.SetHP(0);
        //bool isDead = zombie.IsDead();
        //Debug.Log($"HP: {zombie.GetHP()} / isDead: {isDead}");
    }
}
