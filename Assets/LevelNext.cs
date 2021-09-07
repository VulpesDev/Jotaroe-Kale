using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelNext : MonoBehaviour
{
    static int times = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(JustWait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator JustWait()
    {
        if (times == 0)
        {
            yield return new WaitForSeconds(5f);
            times++;
        }
        else
        {
            yield return new WaitForSeconds(12f);
        }
        GameObject.Find("LevelLoader").GetComponent<LevelLoader>().LoadNextScene();
    }
}
