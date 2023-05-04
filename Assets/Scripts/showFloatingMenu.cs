using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showFloatingMenu : MonoBehaviour
{
    public GameObject floatingMenu;
    
    Transform menuTransform;
    Transform objectPosition;
    Vector3 initialPosition;
    GameObject character;
    CharacterMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Character");
        menuTransform = floatingMenu.GetComponent<Transform>();
        objectPosition = gameObject.GetComponent<Transform>();
        movement = character.GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        GlobalVariables.currentGameObject = gameObject;
        Debug.Log("In showFloating");
        Debug.Log(GlobalVariables.currentGameObject);
        if (!floatingMenu.activeSelf){
            movement.enabled = true;
        }
        if (Input.GetButtonDown("js11")){
            if (floatingMenu.activeSelf){
                floatingMenu.SetActive(false);
                movement.enabled = true;
            }
            menuTransform.position = objectPosition.position + Vector3.up * 2.5f + new Vector3(0,0,-1.0f);
            floatingMenu.SetActive(true);
            GameObject.Find("Grab").GetComponent<grabScript>().enabled = false;
            GameObject.Find("Store").GetComponent<storeScript>().enabled = false;
            GameObject.Find("Exit").GetComponent<exitMenu>().enabled = false;
            movement.enabled = false;
        }
    }
}
