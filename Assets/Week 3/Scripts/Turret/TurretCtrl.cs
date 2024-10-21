using Unity.VisualScripting;
using UnityEngine;

public class TurretCtrl : PersonalBehaviour
{
    [SerializeField] protected TurretTargetSystem turretTargetSystem;
    public TurretTargetSystem TurretTargetSystem => turretTargetSystem;
    [SerializeField] protected Transform rotator;
    public Transform Rotator => rotator;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretTargetSystem();
        this.LoadRotator();
    }
    protected virtual void LoadTurretTargetSystem()
    {
        if (this.turretTargetSystem != null) return;
        this.turretTargetSystem = transform.Find("TurretTargetSystem").GetComponent<TurretTargetSystem>();
        Debug.Log(transform.name + ": LoadTurretTargetSystem", gameObject);
    }
    protected virtual void LoadRotator()
    {
        if (this.rotator!= null) return;
        this.rotator = transform.Find("Model").Find("Rotator");
        Debug.Log(transform.name + ": LoadTurretTargetSystem", gameObject);
    }
}
