using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCar : MonoBehaviour
{
    public Rigidbody rb;
    public float speedRot = 2f;
    public float force = 50f;
    public float maxspeed = 10f;

    private float rot = 00.0f;
    float _sideslipamount = 0;
    Vector3 lastpostion;
    public float limitx, limity;
    public GameObject basket;
    public bool isdrifting;
    public float score;
    float Axishorizontal;

    public float sideslipamount
    {
        get
        {
            return _sideslipamount;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //transform.rotation = Quaternion.Euler(0, 90, 0);
        transform.position = new Vector3(0f, 1.5f, -130f);
    }

    void FixedUpdate()
    {


        rb.AddRelativeForce(Vector3.forward * force, ForceMode.Acceleration);
        if (rb.velocity.magnitude > maxspeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxspeed);

        }
        SetRotation();
        setsideslip();
    }


    public void setsideslip()
    {
        Vector3 direction = transform.position - lastpostion;
        Vector3 movement = transform.InverseTransformDirection(direction);
        lastpostion = transform.position;

        _sideslipamount = movement.x;

    }
    public void SetRotation()
    {
        if (Input.touchCount > 0)
        {

            Vector3 touchPosition = Input.GetTouch(0).position;
            if (touchPosition.x > Screen.width / 2)
            {
                Axishorizontal = Mathf.Lerp(0, 1, 120 * Time.deltaTime);
            }
            else if (touchPosition.x < Screen.width / 2)
            {
                Axishorizontal = Mathf.Lerp(0, -1, 120 * Time.deltaTime);
            }

        }
        else
        {
            Axishorizontal = Mathf.Lerp(Axishorizontal, 0, 120 * Time.deltaTime);
        }


        rot += Axishorizontal * speedRot;
        rot += Input.GetAxis("Horizontal") * speedRot;

        Quaternion target = Quaternion.Euler(0, rot, 0);

            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speedRot);
        
    }
}
