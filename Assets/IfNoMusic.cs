using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfNoMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Music") == null)
        {
            if(!GameObject.Find("Music1").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("Music1").GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            Destroy(GameObject.Find("Music"));
        }
    }
}
