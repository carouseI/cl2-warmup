using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    [SerializeField] GameObject[] diskPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTrans;
    [SerializeField] float maxTrans;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DiskSpawn());
    }

    IEnumerator DiskSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(diskPrefab[Random.Range(0, diskPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
