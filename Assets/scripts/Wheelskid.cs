using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelskid : MonoBehaviour
{
    [SerializeField] float intensityMosifier = 1.5f;

    Skidmarks skidmarkcontroller;
    scriptCar playercar;

    int lastSkidId = -1;
    void Start()
    {
        skidmarkcontroller = FindObjectOfType<Skidmarks>();
        playercar = GetComponentInParent<scriptCar>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        float intensity = playercar.sideslipamount;
        if (intensity < 0)
            intensity = -intensity;

        if (intensity > 0.2f)
        {
            //show skids
            //Debug.Log("tza3ek");

            lastSkidId = skidmarkcontroller.AddSkidMark(transform.position, transform.up, intensity * intensityMosifier, lastSkidId);
            //Debug.Log(intensity);
            playercar.isdrifting = true;
        }
        else
        {
            // stop skids
            lastSkidId = -1;
            //Debug.Log("nn");
            playercar.isdrifting = false;
        }
        
    }
    void Update()
    {
        
    }
}
