using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    public GameObject MenuContainer;
    private GameObject MegoButton;
    public GameObject WholeWorld;
    public GameObject OuterWorldSubjects;
    private bool isMenuEnabled;
    private bool toggleMenu;
    private float speed = 4f;
    private float shrinkScale = 0.033f;
    private float enlargeScale = 5.5f;
    private float normalScale = 1f;
    private float maxRotation = 90f;
    // Start is called before the first frame update
    void Start()
    {   
        toggleMenu = false;

        if(MenuContainer.activeSelf) {
            isMenuEnabled = true;
        } else {
            isMenuEnabled = false;
            gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        }

        // InvokeRepeating("setToggleMenu", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(toggleMenu) {
            float temp = gameObject.transform.localScale.x;
            if(!isMenuEnabled) {
                
                MenuContainer.SetActive(true);
                if(temp >= 1f) {
                    gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    isMenuEnabled = true;
                    toggleMenu = false;
                } else {
                    temp += Time.deltaTime * speed;
                    gameObject.transform.localScale = new Vector3(temp, temp, temp);
                }
            } else {
                if(temp <= 0.01) {
                    gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                    isMenuEnabled = false;
                    MenuContainer.SetActive(false);
                    toggleMenu = false;
                } else {
                    temp -= Time.deltaTime * speed;
                    gameObject.transform.localScale = new Vector3(temp, temp, temp);
                }
            }
        }
        
    }

    public void closeOnSelect(string name) {
        setToggleMenu();
        
    }

    public void setToggleMenu() {
        toggleMenu = true;
    }

    public void shrinkWorld() {
        Debug.Log("shrink world");
        WholeWorld.transform.localScale = new Vector3(shrinkScale, shrinkScale, shrinkScale);
    }

    public void enlargeWorld() {
        Debug.Log("enlarge world");
        WholeWorld.transform.localScale = new Vector3(enlargeScale, enlargeScale, enlargeScale);
    }

    public void returnToNormal() {
        Debug.Log("return to normal world");
        WholeWorld.transform.localScale = new Vector3(normalScale, normalScale, normalScale);
    }

    public void rotateWorldToCeiling() {
        // Hide the outer table and subject so that they won't intesect with inner world while the inner world is rotating
        OuterWorldSubjects.SetActive(false);
    }
}
