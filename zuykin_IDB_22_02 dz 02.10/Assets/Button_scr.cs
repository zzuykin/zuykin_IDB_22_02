using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_scr : MonoBehaviour
{
    public GameObject sphere; 
    public void Deactive(){
        if(sphere.active == true){
        sphere.SetActive(false);
        }
        else if(sphere.active == false){ 
            sphere.SetActive(true); 
        }
    }
}
