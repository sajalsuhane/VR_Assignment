using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class outline_when_pointed : MonoBehaviour
{
    public GameObject object1;
    private Outline quickOutline;
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        object1 = GetComponent<GameObject>();
        quickOutline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        if(Physics.Raycast(ray, out hit)){
          if (quickOutline != null && hit.collider.gameObject != quickOutline.gameObject)
          {
              quickOutline.enabled = false;
          }
          quickOutline = hit.collider.GetComponent<Outline>();
          if (quickOutline.enabled==false)
          {
              quickOutline.enabled = true;
              quickOutline.OutlineMode = Outline.Mode.OutlineVisible;
              quickOutline.OutlineColor = Color.yellow;
              quickOutline.OutlineWidth = 5f;
          }
        }
        else 
        {
          quickOutline.enabled = false;
        }
    }
}
