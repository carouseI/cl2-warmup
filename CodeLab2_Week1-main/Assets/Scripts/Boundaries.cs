using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBoundaries;

    // Start is called before the first frame update
    void Start()
    {
        screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //calculate boundaries in world space
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position; //current obj position
        viewPos.x = Mathf.Clamp(viewPos.x, screenBoundaries.x, screenBoundaries.x * -1); //clamp current x pos to screenBoundaries x pos; current value (-) for min, reversed (+) for max
        viewPos.y = Mathf.Clamp(viewPos.y, screenBoundaries.y, screenBoundaries.y * -1); //y variant
        transform.position = viewPos; //set to new pos
    }
}
