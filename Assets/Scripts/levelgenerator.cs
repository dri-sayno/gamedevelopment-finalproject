using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour {

    public GameObject platformPrefab;

    public Transform generationPoint;
    public float levelWidth = 1.2f;
    public float minY = 1f;
    public float maxY = 1.5f;
    private float platformHeight;

    public GameObject[] platformPrefabs;
    private int platformSelector;

    public objectpooler[] theObjectPools;


    //initial instantiate
    void Start () {
        
	}

    void Update()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            platformHeight = Random.Range(minY, maxY);
            transform.position = new Vector3(Random.Range(levelWidth, -levelWidth), transform.position.y + platformHeight, transform.position.z);

            platformSelector = Random.Range(0, theObjectPools.Length);

            //Instantiate(platformPrefabs[platformSelector], transform.position, Quaternion.identity);
            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();
            if (newPlatform.tag == "Branch-right")
            {
                newPlatform.transform.position = new Vector3(Random.Range(10, 8), transform.position.y + maxY, transform.position.z);
                newPlatform.transform.rotation = transform.rotation;
                newPlatform.SetActive(true);
            }
            else if (newPlatform.tag == "Branch-left")
            {
                newPlatform.transform.position = new Vector3(Random.Range(-10, -8), transform.position.y + maxY, transform.position.z);
                newPlatform.SetActive(true);
            }
            else
            {
                newPlatform.transform.position = transform.position;
                newPlatform.transform.rotation = transform.rotation;
                newPlatform.SetActive(true);
            }
        }
    }
}
