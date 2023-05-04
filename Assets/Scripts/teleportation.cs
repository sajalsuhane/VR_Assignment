using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    public GameObject character;
    Transform characterTransform;
    public GameObject sphere;
    Transform sphereTransform;
    // Start is called before the first frame update
    void Start()
    {
        characterTransform = character.GetComponent<Transform>();
        sphereTransform = sphere.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("js3")){
            Vector3 spherePosition = sphereTransform.position;
            Debug.Log("The position of football is "+spherePosition);
            characterTransform.position = spherePosition + Vector3.up * 2.5f;
            sphere.SetActive(false);
        } 
    }
}
