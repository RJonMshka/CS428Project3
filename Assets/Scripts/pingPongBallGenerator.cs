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
            GameObject newBall = Instantiate(pingPongBall, ballSpawnPoint.position, ballSpawnPoint.rotation);
            if(gameObject.tag == "megoPlayset") {
                newBall.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
            } else if(gameObject.tag == "zeroGravity") {
                newBall.GetComponent<Rigidbody>().useGravity = false;
            }
            isGenerating = true;
            Invoke("SetBallGenerator", 3f);
        }
    }

    void SetBallGenerator() {
        isGenerating = false;
    }
}
