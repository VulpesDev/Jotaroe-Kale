using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1f; // best tested option : 3f  v1
    public float acceleration = 5f; // best tested option : 5f  v1
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal * speed,
            vertical * speed);
        rb.velocity = movement;
        if(movement!= new Vector2(0,0))
        transform.rotation = Quaternion.Lerp
                (transform.rotation, 
                Quaternion.LookRotation(Vector3.forward,
                movement), Time.deltaTime*acceleration);
    }
}
