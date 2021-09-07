using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRadio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Music").transform.GetChild(0)
            .GetComponent<AudioSource>().Stop();
        GameObject.Find("Music").transform.GetChild(1)
            .GetComponent<AudioSource>().Play();
    }

}
