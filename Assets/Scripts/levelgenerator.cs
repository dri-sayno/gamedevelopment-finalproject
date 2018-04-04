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

    //initial instantiate
    void Start () {
        
	}

    void Update()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            platformHeight = Random.Range(minY, maxY);
            transform.position = new Vector3(Random.Range(levelWidth, -levelWidth), transform.position.y + platformHeight, transform.position.z);
            Instantiate(platformPrefab, transform.position, Quaternion.identity);
        }
        //Vector3 spawnPosition = new Vector3();
        //spawnPosition.y += Random.Range(minY, maxY);
        //spawnPosition.x = Random.Range(levelWidth, -levelWidth);
        //Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

    ////endless instantiate
    //public void Levelgenerate () {
    //    Vector3 spawnPosition = new Vector3();
    //    for (int x = 0; x < 1; x++)
    //    {
    //        spawnPosition.y += Random.Range(minY, maxY);
    //        spawnPosition.x = Random.Range(levelWidth, -levelWidth);
    //        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    //    }
    //    Debug.Log("generate", gameObject);
    //}
}
