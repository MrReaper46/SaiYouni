using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
public abstract class DamageSender : PersonalBehaviour
{
    [SerializeField] protected int damage = 1;
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected Collider _collider;
   
    protected virtual void OnTriggerEnter(Collider collider)
    {
        DamageReceiver damageReceiver = collider.transform.parent.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        damageReceiver.Receive(this.damage, this);
        Debug.Log(transform.name + ": " + collider.transform.parent.name, collider.gameObject);
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadRigidbody();
        this.LoadTriggerCollider();
    }
    protected virtual void LoadRigidbody()
    {
        if (this.rb != null) return;
        this.rb = GetComponent<Rigidbody>();
        this.rb.useGravity = false;
        Debug.Log(transform.name + ": LoadRigidbody", gameObject);
    }
    protected virtual void LoadTriggerCollider()
    {
        if (this._collider != null) return;
        this._collider = GetComponent<Collider>();
        this._collider.isTrigger = true;
        Debug.Log(transform.name + ": LoadTriggerCollider", gameObject);
    }
}
 
