using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform GetMarkerWithName(string markerName)
    {
        Transform marker = transform.Find(markerName);
        if (marker == null)
        {
            Debug.LogError($"Location {name} has no marker named {markerName}.");
            return null;
        }
        return marker;
    }
}
