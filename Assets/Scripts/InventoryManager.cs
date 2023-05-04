using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> myInventory;
    int checkForPositionInventory = 0;
    GameObject[] inventoryOptions;
    GameObject Object1;
    GameObject Object2;
    GameObject Object3;
    public GameObject character;
    public GameObject reticle;
    int remote = 0;
    void Start()
    {
        Object1 = GameObject.Find("Object1");
        Object2 = GameObject.Find("Object2");
        Object3 = GameObject.Find("Object3");
        inventoryOptions = new GameObject[]{Object1, Object2, Object3};
        inventoryOptions[0].GetComponent<Image>().color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        myInventory = GlobalVariables.inventory;
        if (myInventory.Count!=0){
            for (int i = 0; i < myInventory.Count; i++)
            {
                Debug.Log("Inventory/" + myInventory[i]);
                Sprite newObject = Resources.Load<Sprite>("Inventory/" + myInventory[i].name);
                GameObject newImage = inventoryOptions[i];
                Image image = newImage.GetComponent<Image>();
                Debug.Log(newImage);
                image.sprite = newObject;
                Debug.Log(inventoryOptions[i]);
            }
            inventoryOptions[0].GetComponent<Image>().color = Color.yellow;
        }
        float hortComp = Input.GetAxis("Horizontal");
        if (hortComp == 0) {
            remote = 0;
        }else {
            if (remote == 0 ) {
                if (hortComp < 0) {
                    remote = 1;
                }else if (hortComp >0) {
                    remote = -1;
                }
                if (remote == 1) {
                    checkForPositionInventory +=1;
                    checkForPosition();
                    resetHighlight();
                }else if (remote == -1){
                    checkForPositionInventory -=1;
                    checkForPosition();
                    resetHighlight();
                }
            }
        }
        if (Input.GetButtonDown("js0")){
            GameObject.Find("Inventory").SetActive(false);
            GameObject.Find("Resume").GetComponent<globalMenuManager>().resumeClick();
        }
        if (Input.GetButtonDown("js5")){
            if (inventoryOptions[checkForPositionInventory].GetComponent<Image>().sprite != null){
                GlobalVariables.currentGameObject = myInventory[checkForPositionInventory];
                GlobalVariables.currentGameObject.SetActive(true);
                GameObject.Find("Inventory").SetActive(false);
                character.SetActive(true);
                reticle.SetActive(true);
                GameObject.Find("GameObjectGrabber").GetComponent<grabber>().enabled = true;
                GlobalVariables.inventory.Remove(GlobalVariables.currentGameObject);
                for (int i = 0; i < inventoryOptions.Length; i++){
                    inventoryOptions[i].GetComponent<Image>().sprite = null;
                }
                Debug.Log(GlobalVariables.inventory);
                Debug.Log("-----------------------");
            }
        }
    }
    public void resetHighlight(){
        inventoryOptions[checkForPositionInventory].GetComponent<Image>().color = Color.yellow;
        for (int i=0; i<inventoryOptions.Length; i++){
            if (i!=checkForPositionInventory){
                inventoryOptions[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public void checkForPosition(){
        if (checkForPositionInventory == 3){
            checkForPositionInventory = 0;
        }
        if (checkForPositionInventory ==-1){
            checkForPositionInventory = 2;
        }
    }
}
