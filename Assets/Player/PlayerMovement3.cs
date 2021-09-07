using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.U2D.Animation;

public class PlayerMovement3 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 20;
    public float acceleration = 50;
    bool off = false;
    Animator anime;

    public AudioSource Walking;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    void Update()
    {
            if (off)
                return;
            if (rb.velocity.x != 0)
            {
                if (!Walking.isPlaying)
                    Walking.Play();
            }
            else
            {
                if (Walking.isPlaying)
                    Walking.Pause();
            }

            float horizontal = Input.GetAxis("Horizontal");
            if (Mathf.Abs(rb.velocity.x) <= speed)
                rb.velocity += new Vector2(horizontal * acceleration *
                    Time.deltaTime, 0);
            anime.SetFloat("Speed", Mathf.Abs(rb.velocity.x) / speed);
            if (rb.velocity.x < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (rb.velocity.x > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {

            }
    }
}
