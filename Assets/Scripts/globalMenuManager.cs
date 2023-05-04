using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Character;
    public GameObject Reticle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resumeClick(){
        GameObject.Find("MainMenu").SetActive(false);
        Character.GetComponent<CharacterMovement>().enabled = true;
        Character.SetActive(true);
        Reticle.SetActive(true);
    }

    public void quitClick(){
        Application.Quit();
    }
}
