using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Checkpoint
{
    public static Dictionary<string, bool> CheckpointClearDictionary = new Dictionary<string, bool>
            {
                {"location1clear",false},
                {"location2clear",false},
                {"location3clear",false},
                {"location4clear",false},
            };

    public static void CheckpointClearTrue(string key)
    {
        CheckpointClearDictionary[key] = true;
    }
    public static void CheckpointClearFalse(string key)
    {
        CheckpointClearDictionary[key] = false;
    }
}