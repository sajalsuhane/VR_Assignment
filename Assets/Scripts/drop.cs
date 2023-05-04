using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject playableObj;
    public GameObject playableParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I am here");
        if(Input.GetButtonDown("js10")){
            playableObj = GlobalVariables.currentGameObject;
            Debug.Log("-----");
            Debug.Log(playableObj);
            Debug.Log("-----");
            playableObj.transform.SetParent(playableParent.transform, true);
            playableObj.GetComponent<Rigidbody>().useGravity = true;
            playableObj.GetComponent<Rigidbody>().isKinematic = false;
            GameObject.Find("GameObjectGrabber").GetComponent<grabber>().enabled = false;
            GameObject.Find("GameObjectGrabber").GetComponent<grabber>().isGrabbed = false;
            GameObject.Find("GameObjectGrabber").GetComponent<drop>().enabled = false;
        }
    }
}
