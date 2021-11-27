using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldRotation : MonoBehaviour
{
    private float rotateFactor = 90f;
    private float rotationDone = 0f;
    private bool rotateLeft;
    private bool rotateRight;   
    private bool rotateWorld; 
    private bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
        rotateLeft = false;
        rotateRight = false; 
        rotateWorld = false; 
        isRotating = false;
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0f);
    }

    // Update is called once per frame
    void Update()
    {   
        if(rotateWorld) {
            float zRotation = gameObject.transform.localRotation.eulerAngles.z;
            
            if(rotateLeft) {
                
                if(rotationDone < rotateFactor) {
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, zRotation + 1f * 10f * Time.deltaTime);
                    rotationDone += 1f * 10f * Time.deltaTime;
                } else {
                    rotationDone = 0f;
                    isRotating = false;
                    toggleRotateWorld();
                }
                
            } else {
                if(rotationDone < rotateFactor) {
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, zRotation - 1f * 10f * Time.deltaTime);
                    rotationDone += 1f * 10f * Time.deltaTime;
                } else {
                    rotationDone = 0f;
                    isRotating = false;
                    toggleRotateWorld();
                }
            }

        }
    }

    public void rotateWorldLeft() {
        if(!isRotating) {
            isRotating = true;
            Debug.Log("Rotating left");
            rotateLeft = true;
            rotateRight = false;
            toggleRotateWorld();
        }
        
    }

    public void rotateWorldRight() {
        if(!isRotating) {
            isRotating = true;
            Debug.Log("Rotating right");
            rotateLeft = false;
            rotateRight = true;
            

            toggleRotateWorld();
        }
        
    }

    private void toggleRotateWorld() {
        rotateWorld = !rotateWorld;
    }

}
