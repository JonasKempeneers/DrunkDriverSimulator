using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Car : MonoBehaviour
{
    private float speed = 0f;
    private float maxSpeed = 1.5f;
    private float acceleration = 0.6f;
    private float deceleration = 0.2f;

    public float rotateSpeed = 5f;

    public GameObject canvas;
    private bool gameOver;

    private void Update()
    {

        if ((Input.GetKey("down")) && (speed < maxSpeed))
                speed = speed - acceleration * Time.deltaTime;
            else if ((Input.GetKey("up")) && (speed < maxSpeed))
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
            transform.Rotate(0f, rotateSpeed * 2 * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
            
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" || gameObject.transform.rotation.z > 90f)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        canvas.SetActive(true);
    }
}
