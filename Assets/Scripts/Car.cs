using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 10f;


    private void Update()
    {
        transform.Translate(0f, 0f, moveSpeed * 20 *Input.GetAxis("Vertical")*Time.deltaTime);
        transform.Rotate( 0f, rotateSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
    }
}
