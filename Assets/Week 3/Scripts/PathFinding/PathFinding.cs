using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding : PersonalBehaviour
{
    [SerializeField] protected List<CheckPoint> checkPoints = new();
    public List<CheckPoint> CheckPoints => checkPoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCheckPoints();
    }
    protected virtual void LoadCheckPoints()
    {
        if (this.checkPoints.Count > 0) return;
        CheckPoint checkPoint;
        foreach(Transform child in transform)
        {
            checkPoint = child.GetComponent<CheckPoint>();
            if (checkPoint == null) continue;
            this.checkPoints.Add(checkPoint);
        }
        Debug.Log(transform.name + ": LoadCheckPoint", gameObject);
    }
    public virtual CheckPoint GetPoint(int pointIndex)
    {
        return this.checkPoints[pointIndex];
    }
}
