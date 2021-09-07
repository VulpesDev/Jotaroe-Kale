using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DoorTopDown : MonoBehaviour
{
    bool inside;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inside)
        {
                if (GameObject.Find("Player").GetComponent<GrabItem>().CheckIfOnlyOneItem())
                {
                    GameObject.Find("Subtittles").GetComponent<TextMeshProUGUI>().text = "Press E to use door.";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                    if(GameObject.Find("Player").GetComponent<GrabItem>().CheckIfCorrectItem())
                    {
                        SceneManager.LoadScene("NoFail");
                    }
                    else
                    {
                        SceneManager.LoadScene("Fail");
                    }
                    }
                }
                else
                {
                    GameObject.Find("Subtittles").GetComponent<TextMeshProUGUI>().text = "Drop all items except one that you think is the correct one.";
                }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inside = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inside = false;
        }
    }
}
