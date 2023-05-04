using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject cube2;
    // Start is called before the first frame update
    void Start()
    {
        cube2 = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("js2")){
            transform.Rotate(Vector3.left * 45.0f * Time.deltaTime);
        }
    }
}
