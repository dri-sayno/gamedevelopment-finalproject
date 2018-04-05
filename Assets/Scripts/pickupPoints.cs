using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupPoints : MonoBehaviour {

    public int scoreToGive;
    private AudioSource coinSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
            if (coinSound.isPlaying)
            {
                coinSound.Stop();
                coinSound.Play();
            }
            else {
                coinSound.Play();
            }
            
            scoremanager.AddScore(scoreToGive);
            gameObject.SetActive(false);
        }
    }
}
