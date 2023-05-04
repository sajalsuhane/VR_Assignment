using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitMenu : MonoBehaviour
{
    GameObject floatingMenu;
    // Start is called before the first frame update
    void Start()
    {
        floatingMenu = GameObject.Find("FloatingMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("js5")){
            floatingMenu.SetActive(false);
            Debug.Log("Exit button hit");
        }
    }
}
