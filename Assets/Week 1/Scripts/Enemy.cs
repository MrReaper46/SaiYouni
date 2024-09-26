using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    public int Level = 10;
    //variables 2
    public float MaxHP = 5000;
    //variables 3 
    public float CurrentHP;
    //variables 4 
    public int Atk = 50;
    //variables 5 
    public int Def = 100;

    // 5 Enemies methods

    //Method 1
    private float AtkVal(int level, int atk, bool isBuffed)
    {
        float multiplier;
        if (isBuffed)
        {
            multiplier = 1;
        }
        multiplier = level * 1.1f;
        float atkVal = (float)atk * multiplier;
        return atkVal;
    }

    //Method 2
    private float DamageVal(int playerAtk, int def)
    {
        float damageVal = (playerAtk * 120) - def;
        if (damageVal < 0)
        {
            return damageVal =  0;
        }
        return damageVal;
    }

    //Method 3
    private float hpRevival(float curHP, float maxHP, int level, bool isInCombat)
    {
        float revivalRate;
        float hpRevivedVal;
        if (curHP < maxHP && isInCombat)
        {
            revivalRate = level * 0.01f;
        }
        revivalRate = 1.0f;
        hpRevivedVal = curHP * revivalRate;
        return hpRevivedVal;

    }
    //Method 4
    private float hpUpdate(float curHP, float damageVal, float hpRevivedVal)
    {
        damageVal = DamageVal(Random.Range(1, 20), Def);
        float hpReductionVal = curHP - damageVal + hpRevivedVal;
        float newCurHP;
        if (curHP <= 0)
        {
            return newCurHP = 0;
        }
        newCurHP = curHP - hpReductionVal;
        return newCurHP;
    }
    //Method 5
    private bool isDead(float curHP)
    {  
        if (curHP > 0)
        {
            return false;
        }
        return true;
    }
    
}
