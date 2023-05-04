using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject character;
    GameObject speedText;
    GameObject resume;
    GameObject inventory;
    GameObject speed;
    GameObject quit;
    GameObject[] menuOptions;
    int currentPosition = 0;
    int remote = 0;
    void Start()
    {
        character = GameObject.Find("Character");
        speedText = GameObject.Find("Speed_Text");
        resume = GameObject.Find("Resume");
        inventory = GameObject.Find("Inventory");
        speed = GameObject.Find("Speed");
        quit = GameObject.Find("Quit");
        menuOptions = new GameObject[]{resume, inventory, speed, quit};
        menuOptions[0].GetComponent<Image>().color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Character").GetComponent<CharacterMovement>().enabled = false;
        if(character.GetComponent<CharacterMovement>().speed == 5f){
            speedText.GetComponent<TextMeshProUGUI>().text = "Speed: Low";
        }
        else if(character.GetComponent<CharacterMovement>().speed == 10f){
            speedText.GetComponent<TextMeshProUGUI>().text = "Speed: Medium";
        }
        else{
            speedText.GetComponent<TextMeshProUGUI>().text = "Speed: High";
        }

        float vertComp = Input.GetAxis("Vertical");
        if (vertComp == 0) {
            remote = 0;
        }else {
            if (remote == 0 ) {
                if (vertComp < 0) {
                    remote = 1;
                }else if (vertComp >0) {
                    remote = -1;
                }
                if (remote == 1) {
                    currentPosition +=1;
                    checkForPosition();
                    resetHighlight();
                }else if (remote == -1){
                    currentPosition -=1;
                    checkForPosition();
                    resetHighlight();
                }
            }
        }
        if (Input.GetButtonDown("js5")){
            if (currentPosition == 0){
                resume.GetComponent<globalMenuManager>().resumeClick();
            }
            else if (currentPosition == 1){
                inventory.GetComponent<InventoryMenuHandler>().showSubMenu();
            }
            else if (currentPosition == 2){
                speed.GetComponent<speedMenuHandler>().changeSpeed();
            }
            else if (currentPosition == 3){
                quit.GetComponent<globalMenuManager>().quitClick();
            }
        }
    }
    public void resetHighlight(){
        menuOptions[currentPosition].GetComponent<Image>().color = Color.yellow;
        for (int i=0; i<menuOptions.Length; i++){
            if (i!=currentPosition){
                menuOptions[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public void resetHighlightAll(){
        for (int i=0; i<menuOptions.Length; i++){
                menuOptions[i].GetComponent<Image>().color = Color.white;
        }
        currentPosition = -100;
    }
    public void checkForPosition(){
        if (currentPosition == 4){
            currentPosition = 0;
        }
        if (currentPosition ==-1){
            currentPosition = 3;
        }
    }
}
    
