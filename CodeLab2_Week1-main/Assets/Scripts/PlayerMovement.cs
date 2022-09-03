using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    private Vector3 currentPosition;

    // Update is called once per frame
    void Update()
    {
        Movement(); //call
    }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.W)) currentPosition.z += speed * Time.deltaTime; //enable movement into z direction
        if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //enable movement into z direction
        if (Input.GetKey(KeyCode.D)) currentPosition.x += speed * Time.deltaTime; //enable movement into z direction
        if (Input.GetKey(KeyCode.A)) currentPosition.x -= speed * Time.deltaTime; //enable movement into z direction

        transform.position = currentPosition; //set to current position
    }
}
