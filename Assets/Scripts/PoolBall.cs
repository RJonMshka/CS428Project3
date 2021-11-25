using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    public AudioSource ballHitSound;
    private float volumeLevel;

    void Start() {
        volumeLevel = ballHitSound.volume;
        ballHitSound.volume = 0f;
        Invoke("ResetBallVolume", 0.2f);
    }

    void OnCollisionEnter (Collision collision) {
        if (!ballHitSound.isPlaying && (collision.collider.name == "pool_ball" || collision.collider.name == "pool_stick")) {
            ballHitSound.Play();
        }
    }

    void ResetBallVolume() {
        ballHitSound.volume = volumeLevel;
    }
}
