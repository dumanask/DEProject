using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public enum PathDisplayMode { None, Paths, Connections }

//[ExecuteInEditMode]
public class AIWaypointNetwork : MonoBehaviour
{
    [HideInInspector] public PathDisplayMode DisplayMode = PathDisplayMode.Connections;
                     
    [HideInInspector] public int UIStartPoint = 0;
    [HideInInspector] public int UIEndPoint = 0;


     public List<Transform> Waypoints = new List<Transform>();    
}