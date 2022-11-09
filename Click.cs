using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    Transform cir;
    public GameObject Circle;
    public GameObject Route;
    static GameObject newRoute;
    bool ClickOn = false;
    bool ClickOff = true;
    // Start is called before the first frame update
    void Start()
    {
        cir = Circle.GetComponent<Transform>();
    }
    void OnMouseEnter() {
        Circle.GetComponent<Renderer>().material.color = Color.red;
    }
    void OnMouseExit(){
        Circle.GetComponent<Renderer>().material.color = Color.white;
    }
    void OnMouseDown() {
        if (!ClickOn){
            Debug.Log("Click On");
            newRoute = Instantiate(Route,Circle.transform.position,Circle.transform.rotation);
            ClickOff = false; 
        }
        
        if (ClickOn){
            Debug.Log("Click Off");
            Destroy(newRoute);
            ClickOff = true;
        }
    }
    void OnMouseUp() {
        if (!ClickOff){
            ClickOn = true;
        }
        if (ClickOff){
            ClickOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
