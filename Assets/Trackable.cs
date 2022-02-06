using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trackable : DefaultTrackableEventHandler
{
    public bool isFound = false;
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        this.isFound = true;
    }
    protected override void OnTrackingLost()
    {
        this.isFound = false;
        base.OnTrackingLost();
    }
}
