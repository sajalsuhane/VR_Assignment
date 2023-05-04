using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenuHandler : MonoBehaviour
{
    public GameObject submenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showSubMenu(){
        submenu.SetActive(true);
        GameObject.Find("MainMenu").SetActive(false);
    }
}
