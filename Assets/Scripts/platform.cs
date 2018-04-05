using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{

    public float jumpForce = 10f;
    public static int ctr = 0;
    [SerializeField] float delayTime;
    private Vector3 startPos;
    //public Transform target;

    private bool moveUp;

    void Start()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

    //moving platforms
    void Update()
    {
    }
}
