using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("js0")){
            MainMenu.SetActive(true);
            if (GameObject.Find("Reticle").activeSelf){
                GameObject.Find("Reticle").SetActive(false);
            }
            GameObject.Find("Character").GetComponent<CharacterMovement>().enabled = false;
        }
    }
}
