using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageSender : PersonalBehaviour
{
    [SerializeField] protected int damage = 1;
    protected virtual void OnTriggerEnter(Collider collider)
    {
        DamageReceiver damageReceiver = collider.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;

        damageReceiver.Receive(this.damage, this);
        Debug.Log(transform.name + ": " + collider.name, collider.gameObject);
    }
}
