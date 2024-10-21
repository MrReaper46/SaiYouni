using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShootSystem : TurretDataProcessor
{
    [SerializeField] protected EnemyCtrl target;
    [SerializeField] protected float timer = 0;
    [SerializeField] protected float delay = 1f;
    [SerializeField] protected int firePointIndex = 0;
    [SerializeField] protected List<FirePoint> firePoints = new();
    protected virtual void FixedUpdate()
    {
        this.GetTarget();
        this.LookAtTarget();
        this.ShootBullet();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadFirePoints();
    }
    protected virtual void GetTarget()
    {
        this.target = this.turretCtrl.TurretTargetSystem.GetTarget();
    }
    protected virtual void LookAtTarget()
    {
        if (this.target == null) return;
        this.turretCtrl.Rotator.LookAt(this.target.transform.position);
    }
    protected virtual void ShootBullet()
    {
        this.timer += Time.fixedDeltaTime;
        if (this.target == null) return;
        if (this.timer < this.delay) return;
        this.timer = 0;

        FirePoint firePoint = this.GetFirePoint();
        EffectSpawner.Instance.SpawnBullet(firePoint.transform.position,firePoint.transform.rotation);
    }
    protected virtual FirePoint GetFirePoint()
    {
        this.firePointIndex++;
        if (this.firePointIndex >= this.firePoints.Count) this.firePointIndex = 0;
        return this.firePoints[this.firePointIndex];
    }
    protected virtual void LoadFirePoints()
    {
        if (this.firePoints.Count > 0) return;
        FirePoint[] firePoints = this.turretCtrl.GetComponentsInChildren<FirePoint>();
        this.firePoints = new List<FirePoint>(firePoints);
        Debug.LogWarning(transform.name + ": LoadFirePoints", gameObject);
    }
}