using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerTriggerUpdate : DefaultTrackableEventHandler
{
    [SerializeField]
    MovingObject movingObj;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        movingObj.moving = true;
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        movingObj.moving = false;
    }
}
