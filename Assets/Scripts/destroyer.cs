using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyer : MonoBehaviour
{
    public static float delayTime = 3f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Egg")
        {
            Invoke("LoadScene", delayTime);
            Debug.Log("collide", gameObject);
        }
    }
    void LoadScene()
    {
        platform.ctr = 0;
        SceneManager.LoadScene(0);
    }
}
