using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingPongBall : MonoBehaviour
{
    private AudioSource pingPongBallSound;

    void Start() {
        pingPongBallSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collision) {
        if (!pingPongBallSound.isPlaying && (collision.collider.name == "tennis_bat" || collision.collider.name == "TableTennisTop" || collision.collider.name == "generatorBase" || collision.collider.name == "ping_pong_ball")) {
            pingPongBallSound.Play();
        }
    }

}
