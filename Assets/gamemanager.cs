using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public Transform cam;
    public GameObject plane1;
    public GameObject plane2;
    public bool count = true;
    float outofcamera =400f;
    
    

    void Update() 
    {

        createplane();

    }
    void createplane()
    {
        if (cam.position.z >= outofcamera)
        {

            if (count == false)
            {
                plane2.transform.position = new Vector3(0, 0, plane2.transform.position.z + 800);
                outofcamera += 400;
                count = true;

            }

            else
            if (count == true)
            {
                plane1.transform.position = new Vector3(0, 0, plane1.transform.position.z + 800);
                outofcamera += 400f;
                count = false;

            }

        }

    }
   
}
