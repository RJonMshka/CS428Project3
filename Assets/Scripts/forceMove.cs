using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceMove : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerPseudoBody;
    public AudioSource AudioClip1;
    public AudioSource AudioClip2;
    private bool keepAddingForce;
    private Rigidbody playerRigidbody;
    void Start()
    {
        keepAddingForce = false;
        playerRigidbody = playerPseudoBody.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(keepAddingForce) {
            addForce();
        }
    }

    public void addForce() {
        playerRigidbody.AddForce(-1 * gameObject.transform.forward * 90f * Time.deltaTime);
    }

    public void changeAddForce() {
        keepAddingForce = !keepAddingForce;
    }

    public void playAudio() {
        if(!AudioClip1.isPlaying) {
            AudioClip1.Play();
        }
    }

    public void stopAudio() {
        AudioClip1.Stop();
        if(!AudioClip2.isPlaying) {
            AudioClip2.Play();
        }
    }
}
