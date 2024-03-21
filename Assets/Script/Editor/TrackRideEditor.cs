using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TrackRide))]
public class TrackRideEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TrackRide track = (TrackRide)target;
        if (GUILayout.Button("У׼���"))
        {
            track.CalibrateEntrance();
        }
        DrawDefaultInspector();
    }
    
}
