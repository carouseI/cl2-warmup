using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    #region //falling enemies
    [SerializeField]
    private float xLimit;

    [SerializeField]
    private float[] xPositions; //float array, predefined positions

    [SerializeField]
    //private GameObject[] circlePrefabs;
    private Sprite[] sprites;

    [SerializeField]
    private Wave[] wave;
    #endregion

    //public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Resources.Load("Prefabs/Circle"));
        InvokeRepeating("Spawn", 1, 1);
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

[System.Serializable]
public class Wave
{
    public float delayTime; //time after which wave spawns
    public float spawnAmount;
}
