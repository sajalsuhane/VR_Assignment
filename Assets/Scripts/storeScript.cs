using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class storeScript : MonoBehaviour
{
    GameObject playableObj;
    public GameObject messageCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playableObj = GlobalVariables.currentGameObject;
        if (Input.GetButtonDown("js5")){
            // Debug.Log("In Store Script");
            // Debug.Log(GlobalVariables.currentGameObject);
            if (GlobalVariables.currentInventorySize<3){
                if (playableObj.activeSelf){
                    playableObj.SetActive(false);
                    GlobalVariables.inventory.Add(GlobalVariables.currentGameObject);
                    GlobalVariables.currentInventorySize +=1;
                }
            }
            else{
                messageCanvas.GetComponent<RectTransform>().position = playableObj.GetComponent<Transform>().position + Vector3.up * 6.0f + new Vector3(0,0,-2.0f);
                messageCanvas.SetActive(true);
                Invoke("DisableCanvas", 2f);
            }
            GameObject.Find("FloatingMenu").SetActive(false);
        }
    }

    void DisableCanvas()
    {
        messageCanvas.SetActive(false);
    }
}
