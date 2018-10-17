using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float speed = 0f;
    public float maxSpeed = 3f;
    public float acceleration = 1f;
    public float deceleration = 1f;
    
    public float rotateSpeed = 5f;


    private void Update()
    {
        if ((Input.GetKey("down")) && (speed < maxSpeed))
            speed = speed - acceleration * Time.deltaTime;
        else if ((Input.GetKey("up")) && (speed > -maxSpeed))
            speed = speed + acceleration * Time.deltaTime;
        else
        {
            if (speed > deceleration * Time.deltaTime)
            speed = speed - deceleration * Time.deltaTime;
            else if (speed < -deceleration * Time.deltaTime)
            speed = speed + deceleration * Time.deltaTime;
            else
            speed = 0;
        }




        transform.Translate(0f, 0f, speed);
        transform.Rotate( 0f, rotateSpeed * 2* Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
    }
}
