using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketcollider : MonoBehaviour
{
    //public List<Transform> prefabs;
    public GameObject prefabs1, prefabs2, prefabs3;
    void Start()
    {
        
        prefabs1.transform.position = new Vector3(0,0,110);
        prefabs2.transform.position = new Vector3(0, 0,240);
        prefabs3.transform.position = new Vector3(0,0, 380);

    }

    void Update()
    {
        
    }

}

