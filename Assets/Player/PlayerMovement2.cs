using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.U2D.Animation;

public class PlayerMovement2 : MonoBehaviour
{
    public GameObject cm0, cm1;
    Rigidbody2D rb;
    public float speed = 20;
    public float acceleration = 50;
    bool off = false;
    Animator anime;

    public AudioSource Walking;

    void Start()
    {
        cm0 = GameObject.Find("Cameras").transform.GetChild(0).gameObject;
        cm1 = GameObject.Find("Cameras").transform.GetChild(1).gameObject;
        cm0.SetActive(true);
        Walking = GameObject.Find("Run").GetComponent<AudioSource>();
        GameObject.FindGameObjectWithTag("MainCamera").
            GetComponent<Animator>().enabled = false;
        cm0.GetComponent<CinemachineVirtualCamera>().Follow = gameObject.transform;
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
    IEnumerator WaitForCam()
    {
        yield return new WaitForSeconds(0.5f);
        cm1.SetActive(false);
        cm0.SetActive(true);
    }
    void JumpThroughWindow()
    {
        anime.SetBool("act1", true);
        off = true;
    }
    public void AnimEnd()
    {
        anime.SetBool("act1", false);
        
        off = false;
        StartCoroutine(WaitForCam());
        transform.position = transform.GetChild(0).position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("znak"))
        {
            JumpThroughWindow();
        }
        else if (collision.CompareTag("znak2"))
        {
            cm0.SetActive(false);
            cm1.SetActive(true);
        }
    }
}
