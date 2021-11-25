using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBehavior : MonoBehaviour
{

    private bool isAngry = false;
    static Animator anim;
    private AudioSource angryAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        angryAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other) {
        if(!angryAudio.isPlaying && !isAngry && other.name == "ExampleAvatar") {
            isAngry = true;
            anim.SetTrigger("playAngry");
            Invoke("SetAngryOff", 3f);
            angryAudio.Play();
        }
    }

    void SetAngryOff() {
        isAngry = false;
    }
}
