using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0; //default score
        scoreText.text = "Score : " + scoreNum; //score text setup
    }

    private void OnTriggerEnter2D(Collider2D Disk)
    {
        if(Disk.tag == "Disk") //if collision with disk tagged obj occurs
        {
            scoreNum++; //increment score
            Destroy(Disk.gameObject); //destroy obj upon collision
            scoreText.text = "Score : " + scoreNum; //update text
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
