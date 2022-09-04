using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour
{
    public ObjectPoolItems[] itemsToPool; //item ref list, defined pre-game; array reqs less memory + performance vs lists

    private List<GameObject> pooledObjects; //list; decrease/increase accordingly

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class ObjectPoolItems
{
    public string circle;
    public int poolAmount; //spawn amount
    public GameObject poolObject; //prefab ref storage
    public bool shouldExpand; //create more obj as required
}
