using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionScript : MonoBehaviour
{
    public Text text;
    public int count;
    void Start(){
        count = 100;
        text.text = "Счётчик(сфера сталкивается с кубом): " + count;
    }
    void ChangeText(int count){
        text.text = "Счётчик(сфера сталкивается с кубом): " + count;

    }

    void OnCollisionEnter(Collision other){

        count--;
        ChangeText(count);
    }


}
