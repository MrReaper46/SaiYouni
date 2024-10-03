using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbstract : MonoBehaviour
{
    string enemyName = "Default";
    int enemyHPCurrent = 100;
    int enemyHPMax = 100;
    bool isDead = false;
    int minHP = 0;
    int maxHP = 100;

    private void Awake()
    {
        this.RandomHP();
    }
    public bool IsDead()
    {
        if (this.enemyHPCurrent <= 0) this.isDead = true;
        else isDead = false;
        return isDead;
    }
    public int GetHP()
    {
        return this.enemyHPCurrent;
    }
    public int SetHP(int newHP)
    {
        this.enemyHPCurrent = newHP;
        return this.enemyHPCurrent;
    }
    protected void RandomHP()
    {
        int newHP = Random.Range(this.minHP, this.maxHP + 1);
        this.SetHP(newHP);
    }
}
