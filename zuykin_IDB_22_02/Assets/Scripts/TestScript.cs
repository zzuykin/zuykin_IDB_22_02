using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSript : MonoBehaviour
{
    public GameObject sphere;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphere = GameObject.Find("Sphere");
            Inst();
        }
    }

    void Inst()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 mv = new Vector3(i, 0, 0);
            Instantiate(sphere, mv, sphere.transform.rotation);
        }
    }
}
