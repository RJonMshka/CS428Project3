using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldRotation : MonoBehaviour
{

    private float currentRotation;
    private float rotateFactor = 90f;
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
        currentRotation = gameObject.transform.localRotation.eulerAngles.z;
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, currentRotation);
    }

    // Update is called once per frame
    void Update()
    {   
        if(rotateWorld) {
            float zRotation = gameObject.transform.localRotation.eulerAngles.z;
            
            if(rotateLeft) {

                if(Mathf.Abs(zRotation - currentRotation) < rotateFactor) {

                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, zRotation + 1f * 10f * Time.deltaTime);
                } else {
                    currentRotation = zRotation;
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, currentRotation);
                    isRotating = false;
                    toggleRotateWorld();
                }
                
            } else {
                if(Mathf.Abs(currentRotation - zRotation) < rotateFactor) {
                    Debug.Log("right in if");
                    Debug.Log("current rotation is: " + currentRotation);
                    Debug.Log("zRotation rotation is: " + currentRotation);
                    Debug.Log("dif is: " + Mathf.Abs(currentRotation - zRotation));
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, zRotation - 1f * 10f * Time.deltaTime);
                    if(currentRotation == 0f || currentRotation < 0.1f && currentRotation > -0.1f) {
                        currentRotation = 360f;
                    }
                } else {
                    Debug.Log("right in else");
                    currentRotation = zRotation;
                    gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, currentRotation);
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
