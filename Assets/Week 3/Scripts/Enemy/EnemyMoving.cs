using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : EnemyAbstract
{
    [SerializeField] protected PathFinding path;
    [SerializeField] protected int currentCheckPointIndex = 0;
    [SerializeField] protected CheckPoint currentCheckPoint;
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 1f;
    [SerializeField] protected bool isFinished = false;
    [SerializeField] protected bool isMoving = false;
    void FixedUpdate()
    {
        this.Moving();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPathFinding();
    }
    protected virtual void LoadPathFinding()
    {
        if (this.path != null) return;
        this.path = GameObject.Find("CheckPoints").GetComponent<PathFinding>();
        Debug.Log(transform.name + ": LoadCheckPoints", gameObject);
    }
    protected virtual void Moving()
    {
        this.LoadMovingStatus();
        if (this.isFinished)
        {
            this.ctrl.Agent.isStopped = true;
            return;
        }
        this.LoadNextPoint();
        this.ctrl.Agent.SetDestination(this.currentCheckPoint.transform.position);
    }
    protected virtual void LoadNextPoint()
    {
        this.currentCheckPoint = this.path.GetPoint(this.currentCheckPointIndex);
        this.pointDistance = Vector3.Distance(this.currentCheckPoint.transform.position, transform.position);
        if (this.pointDistance < this.pointDistanceLimit) this.currentCheckPointIndex++;
        if (this.currentCheckPointIndex > this.path.CheckPoints.Count - 1) this.isFinished = true;
    }
    protected virtual void LoadMovingStatus()
    {
        this.isMoving = !this.ctrl.Agent.isStopped;
        this.ctrl.Animator.SetBool("isMoving", this.isMoving);
    }
}
