using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TrackedEvent
{
    public static Dictionary<string, bool> TrackedObjectDictionary = new Dictionary<string, bool>
            {
                {"location1",false},
                {"location2",false},
                {"location3",false},
                {"location4",false},
            };

    public static void SetTrackedTrue(string key)
    {
        TrackedObjectDictionary[key] = true;
    }
    public static void SetTrackedFalse(string key)
    {
        TrackedObjectDictionary[key] = false;
    }
}