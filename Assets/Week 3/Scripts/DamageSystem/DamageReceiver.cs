using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageReceiver : PersonalBehaviour
{
    [SerializeField] protected int currentHP = 10;
    [SerializeField] protected int maxHP = 10;
    [SerializeField] protected bool isDead = false;
    public virtual void Receive(int damage, DamageSender damageSender)
    {
        this.currentHP -= damage;
        if (this.currentHP < 0) this.currentHP = 0;
        if (this.IsDead()) this.OnDead();
        else this.OnHurt();
    }
    public virtual bool IsDead()
    {
        this.isDead = this.currentHP <= 0;
        return isDead;
    }
    protected virtual void OnDead()
    {
        //For override
    }
    protected virtual void OnHurt()
    {
        //For override
    }

}
