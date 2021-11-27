using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampBehavior : MonoBehaviour
{

    private bool isLampGrabbed;
    public GameObject LampLight;
    public AudioSource OnSound;
    public AudioSource OffSound;
    // Start is called before the first frame update
    void Start()
    {
        isLampGrabbed = false;
    }

    public void setLampGrabbed(bool status) {
        isLampGrabbed = status;
    }

    public void turnOnLight() {
        if(isLampGrabbed) {
            LampLight.SetActive(true);
            if(!OnSound.isPlaying) {
                OnSound.Play();
            }
        }
    }

    public void turnOffLight() {
        if(isLampGrabbed) {
            LampLight.SetActive(false);
            if(!OffSound.isPlaying) {
                OffSound.Play();
            }
        }
    }

    public void turnOffLightOnUnGrab() {
        LampLight.SetActive(false);
    }
}
