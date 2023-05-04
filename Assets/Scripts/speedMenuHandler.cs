using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject character;
    void Start()
    {
        character = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeSpeed(){
        character.GetComponent<CharacterMovement>().enabled = true;
        if (character.GetComponent<CharacterMovement>().speed == 20f){
            character.GetComponent<CharacterMovement>().speed = 10f;
        }
        else if (character.GetComponent<CharacterMovement>().speed == 10f){
            character.GetComponent<CharacterMovement>().speed = 5f;
        }
        else{
            character.GetComponent<CharacterMovement>().speed = 20f;
        }
        character.GetComponent<CharacterMovement>().enabled = false;
    }
}
