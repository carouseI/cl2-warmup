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
    private GameObject[] circlePrefabs;
    //private Sprite[] sprites;

    [SerializeField]
    private Wave[] wave;

    private float currentTime; //calculate time passed since wave started

    List<float> remainingPositions = new List<float>();
    private int waveIndex; //wave selector
    float xPos = 0; //position @ which circle will spawn
    int rand;
    #endregion

    //public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Resources.Load("Prefabs/Circle"));
        InvokeRepeating("Spawn", 1, 1);

        currentTime = 0; //spawn @ game start
        remainingPositions.AddRange(xPositions); //add all positions to remainingPos list
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Spawn()
    //{
    //    GameObject go = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject; //spawn prefabs
    //    int num = GetComponent<ColorPicker>().SetSprite(); //call colour picker
    //    go.GetComponent<SpriteRenderer>().sprite = sprites[num]; //call sprite renderer
    //}

    void SpawnCircle(float xPos)
    {
        int r = Random.Range(0, 4); //4 circle types
        GameObject circleObj = Instantiate(circlePrefabs[r], new Vector3(xPos, transform.position.y, 0), Quaternion.identity); //spawn @ same pos as spawner; quaternion.identity = cancel rotation, use circleObj as default

    }

    void SelectWave()
    {
        remainingPositions = new List<float>(); //reset list
        remainingPositions.AddRange(xPositions); //add positions

        waveIndex = Random.Range(0, wave.Length); //random select

        currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount == 1)
            xPos = Random.Range(-xLimit, xLimit);
    }
}

[System.Serializable]
public class Wave
{
    public float delayTime; //time after which wave spawns
    public float spawnAmount;
}
