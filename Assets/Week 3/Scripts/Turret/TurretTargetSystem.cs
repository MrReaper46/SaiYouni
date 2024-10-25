using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(SphereCollider))]
public class TurretTargetSystem : PersonalBehaviour
{
    [SerializeField] protected List<EnemyCtrl> enemies = new();
    [SerializeField] protected EnemyCtrl nearest;
    [SerializeField] protected SphereCollider turretCollider;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretCollider();
    }
    protected virtual void LoadTurretCollider()
    {
        if (this.turretCollider != null) return;
        this.turretCollider = GetComponent<SphereCollider>();
        this.turretCollider.isTrigger = true;
        this.turretCollider.radius = 12;
        Debug.Log(transform.name + ": LoadTurretCollider", gameObject);
    }
    protected virtual void FixedUpdate()
    {
        this.FindNearest();
    }
    protected virtual void OnTriggerEnter(Collider collider)
    {
        Targettable targettable = collider.GetComponent<Targettable>();
        if (targettable == null) return;

        EnemyCtrl enemyCtrl = collider.GetComponentInParent<EnemyCtrl>();
        if (enemyCtrl == null) return;

        this.AddEnemy(enemyCtrl);
        Debug.Log(transform.name + ": " + collider.name, collider.gameObject);
    }
    protected virtual void OnTriggerExit(Collider collider)
    {
        EnemyCtrl enemyCtrl = collider.GetComponentInParent<EnemyCtrl>();
        if (enemyCtrl == null) return;
        
        this.RemoveEnemy(enemyCtrl);
    }    
    protected virtual void AddEnemy(EnemyCtrl enemyCtrl)
    {
        this.enemies.Add(enemyCtrl);
    }
    protected virtual void RemoveEnemy(EnemyCtrl enemyCtrl)
    {
        if (this.nearest == enemyCtrl) this.nearest = null;
        this.enemies.Remove(enemyCtrl);
    }
    protected virtual void FindNearest()
    {
        float nearestDistance = Mathf.Infinity;
        float enemyDistance;
        foreach(EnemyCtrl enemyCtrl in this.enemies)
        {
            enemyDistance = Vector3.Distance(transform.position, enemyCtrl.transform.position);
            if(enemyDistance < nearestDistance)
            {
                nearestDistance = enemyDistance;
                this.nearest = enemyCtrl;
            }
        }
    }
    public virtual EnemyCtrl GetTarget()
    {
        return this.nearest;
    }
}
