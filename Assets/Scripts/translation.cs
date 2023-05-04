using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translation : MonoBehaviour
{
    public GameObject cube1;
    // Start is called before the first frame update
    void Start()
    {
        cube1 = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("js2")){
            transform.Translate(Vector3.up * Time.deltaTime * 2.0f);
        } 
    }
}
