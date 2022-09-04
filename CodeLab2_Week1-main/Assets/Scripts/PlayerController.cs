using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    private Vector3 playerPosition;

    private void Start()
    {
        playerPosition = transform.position; //set player default pos
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W)) currentPosition.z += speed * Time.deltaTime; //enable vertical movement (u)
        //if (Input.GetKey(KeyCode.S)) currentPosition.z -= speed * Time.deltaTime; //enable vertical movement (d)
        if (Input.GetKey(KeyCode.D)) playerPosition.x += movementSpeed * Time.deltaTime; //enable lateral movement (l)
        if (Input.GetKey(KeyCode.A)) playerPosition.x -= movementSpeed * Time.deltaTime; //enable lateral movement (r)

        transform.position = playerPosition; //set to current position
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Disk")) //if tagged
        {
            Destroy(other.gameObject); //destroy obj
        }
    }
}