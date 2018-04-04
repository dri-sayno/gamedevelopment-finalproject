using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class controls : MonoBehaviour {

    public float movementSpeed = 10f;
    float movement = 0f;
    Rigidbody2D rb;
    float leftConstraint = -3f;
    float rightConstraint = 3f;
    float buffer = 1.0f;
    Vector3 eggPosition = new Vector3();

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        leftConstraint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 0.05f, 0.0f, 0.0f)).x;
        rightConstraint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * 0.95f, 0.0f, 0.0f)).x;
    }
	
	void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        eggPosition.x = gameObject.transform.position.x;
        if (eggPosition.x < leftConstraint - buffer)
        { 
            eggPosition.x = rightConstraint + buffer;
        }

        else if (eggPosition.x > rightConstraint + buffer)
        {
            eggPosition.x = leftConstraint - buffer;
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
