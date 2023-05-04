using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabScript : MonoBehaviour
{
    GameObject flMenu;
    GameObject grabber;
    // Start is called before the first frame update
    void Start()
    {
        flMenu = GameObject.Find("FloatingMenu");
        grabber = GameObject.Find("GameObjectGrabber");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("js5")){
            Debug.Log("In Grab Script");
            grabber.GetComponent<grabber>().enabled = true;
            flMenu.SetActive(false);
        }
    }
}
