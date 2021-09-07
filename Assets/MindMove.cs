using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MindMove : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject.Find("Music3").GetComponent<AudioSource>().Pause();
    }
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Horizontal, Vertical);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Path"))
        {
            Debug.Log("Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
