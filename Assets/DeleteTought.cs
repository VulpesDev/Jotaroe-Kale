using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTought : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(DelText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DelText()
    {
        yield return new WaitForSeconds(5f);
        GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
        Destroy(gameObject);
    }
}
