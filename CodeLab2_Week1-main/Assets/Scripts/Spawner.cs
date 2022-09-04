using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject; //spawn prefabs
        int num = GetComponent<ColorPicker>().SetSprite(); //call colour picker
        go.GetComponent<SpriteRenderer>().sprite = sprites[num]; //call sprite renderer
    }
}
