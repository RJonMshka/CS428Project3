using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    public GameObject MenuContainer;
    private bool isMenuEnabled;
    private bool toggleMenu;
    private float speed = 4f;
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

}
