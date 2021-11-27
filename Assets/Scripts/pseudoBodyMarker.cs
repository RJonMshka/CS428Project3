using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pseudoBodyMarker : MonoBehaviour
{
    public GameObject RealMarker;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.eulerAngles = new Vector3(RealMarker.transform.eulerAngles.x, RealMarker.transform.eulerAngles.y, RealMarker.transform.eulerAngles.z);
        Debug.Log("x is: " + gameObject.transform.eulerAngles.x + " , y is: " + RealMarker.transform.eulerAngles.y + " , z is: " + RealMarker.transform.eulerAngles.z);
    }
}
