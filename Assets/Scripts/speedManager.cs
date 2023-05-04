using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedManager : MonoBehaviour
{
    GameObject character;
    GameObject High;
    GameObject Medium;
    GameObject Low;
    int currentPositionSpeed = 0;
    GameObject[] menuOptionsSpeed;
    GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Character");
        High = GameObject.Find("High");
        Medium = GameObject.Find("Medium");
        Low = GameObject.Find("Low");
        GameObject.Find("MainMenu").GetComponent<MainMenuHandler>().resetHighlightAll();
        menuOptionsSpeed = new GameObject[]{High, Medium, Low};
        menuOptionsSpeed[0].GetComponent<Image>().color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("js0")){
            currentPositionSpeed +=1;
            checkForPositionSpeed();
            resetHighlightSpeed();
        }
        else if(Input.GetButtonDown("js4")){
            currentPositionSpeed-=1;
            checkForPositionSpeed();
            resetHighlightSpeed();
        }
    }
    public void resetHighlightSpeed(){
        menuOptionsSpeed[currentPositionSpeed].GetComponent<Image>().color = Color.yellow;
        for (int i=0; i<menuOptionsSpeed.Length; i++){
            if (i!=currentPositionSpeed){
                menuOptionsSpeed[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public void highSpeed(){
        character.GetComponent<CharacterMovement>().speed = 20f;
        GameObject.Find("SpeedSubMenu").SetActive(false);
    }
    public void mediumSpeed(){
        character.GetComponent<CharacterMovement>().speed = 10f;
        GameObject.Find("SpeedSubMenu").SetActive(false);
    }
    public void lowSpeed(){
        character.GetComponent<CharacterMovement>().speed = 5f;
        GameObject.Find("SpeedSubMenu").SetActive(false);
    }
    public void checkForPositionSpeed(){
        if (currentPositionSpeed == 3){
            currentPositionSpeed = 0;
        }
        if (currentPositionSpeed ==-1){
            currentPositionSpeed = 2;
        }
    }
}
