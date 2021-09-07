using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerActivation : MonoBehaviour
{
    public GameObject player;
    public bool Active = false;
    float TimeRemeaning = 10.00f;
    public TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeRemeaning<=0)
        {
            SceneManager.LoadScene("Couldnt");
        }
        if (Active)
        {
            TimeRemeaning -= Time.deltaTime;
            txt.text = TimeRemeaning.ToString("F2");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(player, transform.position, transform.rotation);
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
    public void Activate()
    {
        Active = true;
    }
}
