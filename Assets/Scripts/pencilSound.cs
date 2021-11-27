using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencilSound : MonoBehaviour
{
    void OnCollisionEnter (Collision collision) {
        
        if(collision.collider.name == "SubjectTable") {
            if(!gameObject.GetComponent<AudioSource>().isPlaying) {
                gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
