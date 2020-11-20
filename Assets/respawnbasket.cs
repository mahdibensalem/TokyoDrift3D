using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnbasket : MonoBehaviour
{
    public GameObject basketPref;
    public int basketcount;
    public float distance;
    public int LastPosition =0;
    void Start()
    {
        
    }
    void Update()
    {
        while (basketcount<5)
        {
            float RandomRotY = Random.Range(-65, 35);
            float RandomPosX = Random.Range(-40, 40);
            GameObject levelObj = Instantiate (basketPref,new Vector3(RandomPosX, 0, (basketPref.transform.position.z + LastPosition)) ,Quaternion.Euler(0,RandomRotY,90)) as GameObject;
            Level level = levelObj.GetComponent<Level>();
            LastPosition += level.Scale;

            basketcount++;
        }
         
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BasketColiDead")
        {

            Destroy(other.gameObject);
            basketcount--;
            Debug.Log(gameObject.name);
        }
    }
}
