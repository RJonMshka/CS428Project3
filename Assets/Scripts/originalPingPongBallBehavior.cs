using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class originalPingPongBallBehavior : MonoBehaviour
{
    private float ballVolume;
    private AudioSource ballAudio;
    // Start is called before the first frame update
    void Start()
    {
        ballAudio = GetComponent<AudioSource>();
        ballVolume = ballAudio.volume;
        ballAudio.volume = 0f;
        Invoke("ResetBallVolume", 0.2f);
    }

    void ResetBallVolume() {
        ballAudio.volume =ballVolume;
    }
}
