using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class DamageSender : PersonalBehaviour
{
    [SerializeField] protected int damage = 1;
    [SerializeField] protected Collider _collider;
   
    protected virtual void OnTriggerEnter(Collider collider)
    {
        DamageReceiver damageReceiver = collider.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;

        damageReceiver.Receive(this.damage, this);
        Debug.Log(transform.name + ": " + collider.name, collider.gameObject);
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTriggerCollider();
    }
    protected virtual void LoadTriggerCollider()
    {
        if (this._collider != null) return;
        this._collider = GetComponent<Collider>();
        this._collider.isTrigger = true;
    }
}
