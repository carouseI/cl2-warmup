using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("W"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("A"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("S"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("D"))
        {
            pos.x += speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
