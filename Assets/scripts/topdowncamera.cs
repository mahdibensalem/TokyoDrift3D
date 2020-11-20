using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class topdowncamera : MonoBehaviour
{
    public Transform car;
    ////public Vector3 offset;
    public float xSmooth = 3f;
    //////float zpositiondif = 0;
    ////public float offsetcar = -150;
    ////// public float camerasize;
    private void Start()
    {
        this.transform.position = new Vector3(0, 35, -50);
    }
    void FixedUpdate() 
    {
        
        float interpolation = xSmooth * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.z = Mathf.Lerp(this.transform.position.z, car.transform.position.z, interpolation);

        this.transform.position = position;
        //if (transform.position.z - car.transform.position.z < offsetcar)
        //{

        //    transform.position = new Vector3(offset.x, offset.y, offset.z + car.transform.position.z);
        //    //offset.z = Mathf.Lerp(transform.position.z, car.position.z, xSmooth * Time.deltaTime);
        //}







    }
}
