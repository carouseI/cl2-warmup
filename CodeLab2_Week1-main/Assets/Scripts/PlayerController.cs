using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    private float move;
    //private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>(); //check for player rb comp
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal"); //get lateral movt input

        //rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y); //apply velocity to rb
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Disk")) //if tagged
        {
            Destroy(other.gameObject); //destroy obj
        }
    }
}
