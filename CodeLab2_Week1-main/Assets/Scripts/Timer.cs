using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public bool timerIsRunning = false;

    public Text timeText;

    public GameObject endText;
    public GameObject labelText;

    public GameObject player;

    public string endScene;

    public float TIME_LIMIT = 5f; //initialise scene change after 5sec

    public GameObject sceneChanger;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true; //auto start timer
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning) //set countdown trigger
        {
            if(timeRemaining > 0) //if greater than 0
            {
                timeRemaining -= Time.deltaTime; //generate coundown, decrease time
            }

            else
            {
                timeRemaining = 0; //time's up
                timerIsRunning = false; //stop timer @ countdown

                labelText.SetActive(false); //hide label @ countdown
                gameObject.GetComponent<Text>().enabled = false; //hide counter
                endText.SetActive(true); //replace with end text
                player.GetComponent<PlayerController>().enabled = false; //freeze player controller

                StartCoroutine(SwitchScene());
            }
        }

        DisplayTime(timeRemaining);
    }

    void SceneChange()
    {
        SceneManager.LoadScene(endScene);
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(TIME_LIMIT); //wait time between scene transition

        SceneManager.LoadScene(endScene);
        Debug.Log("Loading scene");
    }

    void DisplayTime(float timeToDisplay) //hide timer frame glitch where value is less than 0
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;

        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //calculate minute; FloorToInt to round down
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // % = modulo, removes full minutes and returns leftover values/return remainder of equation; calculate number of seconds in time value that don't add to a full minute
        float milliseconds = timeToDisplay % 1 * 1000; //show milliseconds

        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds); //{parameters}
    }
}
