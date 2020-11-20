using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public scriptCar playercar;
    public triggerline line;
    public GameObject chabka;
    public GameObject lineobject;

    void Start()
    {

    }

    void Update()
    {
        if ((playercar.isdrifting)&& (line.trjggerline))
        {
            Destroy(chabka);
            playercar.score++;
            Destroy(lineobject);
            line.trjggerline = false;
        }
    }
    

}
