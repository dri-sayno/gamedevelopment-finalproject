using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour {

    private scoremanager thescoremanager;

	// Use this for initialization
	void Start () {
        thescoremanager = FindObjectOfType<scoremanager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
