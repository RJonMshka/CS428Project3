using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingPongBallGenerator : MonoBehaviour
{
    public GameObject pingPongBall;
    public Transform ballSpawnPoint;
    private bool isGenerating = false;

    void OnTriggerEnter (Collider other) {
        if(!isGenerating && other.name == "ExampleAvatar") {
            Instantiate(pingPongBall, ballSpawnPoint.position, ballSpawnPoint.rotation);
            isGenerating = true;
            Invoke("SetBallGenerator", 3f);
        }
    }

    void SetBallGenerator() {
        isGenerating = false;
    }
}
