using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disbeliefBehavior : MonoBehaviour
{
    private bool isSad = false;
    static Animator anim;
    private AudioSource sadAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sadAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other) {
        if(!sadAudio.isPlaying && !isSad && other.name == "ExampleAvatar") {
            isSad = true;
            anim.SetTrigger("getSad");
            Invoke("SetSadOff", 3f);
            sadAudio.Play();
        }
    }

    void SetSadOff() {
        isSad = false;
    }
}
