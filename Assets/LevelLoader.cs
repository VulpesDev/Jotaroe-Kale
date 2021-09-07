using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    Animator anime;
    private void Start()
    {
        anime = GetComponentInChildren<Animator>();
    }
    public void LoadNextScene ()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        anime.SetTrigger("Fade");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
