using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Music3").GetComponent<AudioSource>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
