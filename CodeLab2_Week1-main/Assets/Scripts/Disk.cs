using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    [SerializeField] GameObject[] diskPrefab; //prefab ref storage
    [SerializeField] float secondSpawn = 0.5f; //time @ which next wave spawns
    [SerializeField] float minTrans; //furthest possible spawn point to the left
    [SerializeField] float maxTrans; //furthest possible spawn point to the right

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DiskSpawn());
    }

    IEnumerator DiskSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans); //spawn within min + max transforms
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(diskPrefab[Random.Range(0, diskPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn); //spawn frequency
            Destroy(gameObject, 5f); //remove from scene

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
