using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabber : MonoBehaviour
{
    GameObject playableObj;
    public GameObject reticle;
    Transform tmpParent;
    [HideInInspector] public bool isGrabbed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpParent = reticle.GetComponent<Transform>();
        Debug.Log("Before drop enable");
        GameObject.Find("GameObjectGrabber").GetComponent<drop>().enabled = true;
        if(!isGrabbed){
            playableObj = GlobalVariables.currentGameObject;
            GameObject.Find("Character").GetComponent<CharacterMovement>().enabled = true;
            playableObj.GetComponent<Rigidbody>().useGravity = false;
            playableObj.GetComponent<Rigidbody>().isKinematic = true;
            playableObj.transform.position = reticle.transform.position;
            playableObj.transform.parent = tmpParent.transform;
            isGrabbed = true;
        }
    }
}
