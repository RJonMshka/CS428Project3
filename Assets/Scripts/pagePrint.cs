using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pagePrint : MonoBehaviour
{
    public GameObject page;
    public Transform spawnTransform;
    public AudioSource sound;
    public AudioSource taskTwoAudio;
    public GameObject TaskOneMark;
    public GameObject TaskTwoMark;
    public GameObject TasksComplete;
    private bool isTaskTwoComplete = false;
    private bool isPrinting = false;
    private float pageForce = 90f;


    void OnTriggerEnter (Collider other) {
        if(!isPrinting && other.name == "ExampleAvatar") {
            if(!isTaskTwoComplete) {
                UpdateTasks();
            }
            isTaskTwoComplete = true;
            isPrinting = true;
            Invoke("SetPrintingOff", 4f);
            if(!sound.isPlaying) {
                sound.Play();
            }
            CreatePage();
        }
    }

    void SetPrintingOff() {
        isPrinting = false;
    }

    void CreatePage() {
        GameObject newPage;

        newPage = Instantiate(page, spawnTransform.position, spawnTransform.rotation);
        if(gameObject.tag == "megoPlayset") {
            newPage.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
        } else if(gameObject.tag == "zeroGravity") {
            newPage.GetComponent<Rigidbody>().useGravity = false;
        }
        Rigidbody pageRigidbody;
        pageRigidbody = newPage.GetComponent<Rigidbody>();

        pageRigidbody.AddForce(transform.forward * pageForce);

    }

    void UpdateTasks() {
        TaskTwoMark.SetActive(true);
        if(TaskOneMark.activeSelf) {
            TasksComplete.SetActive(true);
        }
        if(!taskTwoAudio.isPlaying) {
            taskTwoAudio.Play();
        }
    }
    
}
