using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TurretTargetSystem : PersonalBehaviour
{
    [SerializeField] List<EnemyCtrl> enemies = new();
    [SerializeField] EnemyCtrl nearest;
    
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
}
