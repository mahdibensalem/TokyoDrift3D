using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerline : MonoBehaviour
{
    // Start is called before the first frame update
    public bool trjggerline=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Car")
        {
            trjggerline = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Car")
        {
            trjggerline = false;
        }
    }
}
