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
        pooledObjects = new List<GameObject>(); //set to empty @ start

        foreach(ObjectPoolItems item in itemsToPool)
        {
            for (int i = 0; i < item.poolAmount; i++)
            {
                GameObject obj = Instantiate(item.poolObject);
                obj.name = item.name;
                obj.transform.parent = this.transform; //set as parent
                obj.SetActive(false); //deactivate
                pooledObjects.Add(obj);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class ObjectPoolItems
{
    public string name;
    public int poolAmount; //spawn amount
    public GameObject poolObject; //prefab ref storage
    public bool shouldExpand; //create more obj as required
}
