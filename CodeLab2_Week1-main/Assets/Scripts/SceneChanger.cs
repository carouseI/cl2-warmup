using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        Debug.Log("clicked"); //check button functionality
        SceneManager.LoadScene(sceneName); //load next scene
    }
}
