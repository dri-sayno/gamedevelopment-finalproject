using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour {

    public GameObject platformPrefab;

    public int platformNumber = 200;
    public float levelWidth = 5f;
    public float minY = 1f;
    public float maxY = 1.5f;

    void Start () {
        Vector3 spawnPosition = new Vector3();
        for (int x = 0; x < platformNumber; x++) {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x += Random.Range(levelWidth, -levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
	}
}
