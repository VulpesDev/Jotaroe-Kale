using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhonePick : MonoBehaviour
{
    bool inrange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inrange)
            GameObject.Find("LevelLoader").GetComponent<LevelLoader>().LoadNextScene();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            inrange = true;
            
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            inrange = false;
        }
    }
}
