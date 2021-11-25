using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderSystem : MonoBehaviour
{
    public GameObject TaskOneMark;
    public GameObject TaskTwoMark;
    public GameObject TasksComplete;
    public AudioSource JobCompleteAudio;
    private bool isRed = false;
    private bool isGreen = false;
    private bool isBlue = false;
    private bool activateFolderTask = false;


    void OnCollisionEnter (Collision collision) {
        
        switch (collision.collider.name) {
            case "folderRed":
                isRed = true;
                break;
            case "folderGreen":
                isGreen = true;
                break;
            case "folderBlue":
                isBlue = true;
                break;
            default:
                break;
        }

        if((isBlue || isGreen || isRed) && !activateFolderTask) {
            Debug.Log("task 1 complete");
            activateFolderTask = true;
            
            CompleteTaskOne();
        } else {
            Debug.Log("do nothing");
        }
    }

    void CompleteTaskOne () {
        TaskOneMark.SetActive(true);
        PlayAudio();

        if(TaskTwoMark.activeSelf) {
            TasksComplete.SetActive(true);
        }
    }

    void PlayAudio () {
        if(!JobCompleteAudio.isPlaying) {
            JobCompleteAudio.Play();
        }
    }
}
