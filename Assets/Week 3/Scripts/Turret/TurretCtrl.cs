using Unity.VisualScripting;
using UnityEngine;

public class TurretCtrl : PersonalBehaviour
{
    [SerializeField] protected TurretTargetSystem turretTargetSystem;
    [SerializeField] protected SphereCollider turretCollider;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretTargetSystem();
        this.LoadTurretCollider();
    }

    protected virtual void LoadTurretTargetSystem()
    {
        if (turretTargetSystem != null) return;
        this.turretTargetSystem = transform.Find("TurretTargetSystem").GetComponent<TurretTargetSystem>();
        Debug.Log(transform.name + ": LoadTurretTargetSystem", gameObject);
    }
    protected virtual void LoadTurretCollider()
    {
        if (turretCollider != null) return;
        this.turretCollider = transform.Find("TurretTargetSystem").GetComponent<SphereCollider>();
        this.turretCollider.isTrigger = true;
        this.turretCollider.radius = 15;
        Debug.Log(transform.name + ": LoadTurretTargetSystem", gameObject);
    }
}
