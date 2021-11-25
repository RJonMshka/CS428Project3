using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampBehavior : MonoBehaviour
{

    private bool isLampGrabbed;
    public GameObject LampLight;
    // Start is called before the first frame update
    void Start()
    {
        isLampGrabbed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLampGrabbed(bool status) {
        isLampGrabbed = status;
    }

    public void turnOnLight() {
        if(isLampGrabbed) {
            LampLight.SetActive(true);
        }
    }

    public void turnOffLight() {
        if(isLampGrabbed) {
            LampLight.SetActive(false);
        }
    }

    public void turnOffLightOnUnGrab() {
        LampLight.SetActive(false);
    }
}
