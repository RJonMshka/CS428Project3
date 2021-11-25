using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeRotationDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if(other.name == "ExampleAvatar") {
            GetComponent<Rigidbody>().freezeRotation = false;
        }
    }
}
