using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    
    public void loadMegoPlaysetScene() {
        SceneManager.LoadScene("MegoPlaysetScene");
    }

    public void loadNormalScene() {
        SceneManager.LoadScene("NormalScene");
    }

    public void loadLandOfGiantsScene() {
        SceneManager.LoadScene("LandOfGiantsScene");
    }


    public void loadDancingOnTheCeilingScene() {
        SceneManager.LoadScene("DancingOnTheCeilingScene");
    }


    public void loadZeroGravityScene() {
        SceneManager.LoadScene("ZeroGravityScene");
    }

}
