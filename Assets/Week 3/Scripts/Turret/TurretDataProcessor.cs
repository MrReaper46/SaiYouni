using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDataProcessor : PersonalBehaviour
{
    [SerializeField] protected TurretCtrl turretCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretCtrl();
    }
    protected virtual void LoadTurretCtrl()
    {
        if (this.turretCtrl != null) return;
        this.turretCtrl = GetComponentInParent<TurretCtrl>();
        Debug.Log(transform.name + ": LoadTurretCtrl", gameObject);
    }
}
