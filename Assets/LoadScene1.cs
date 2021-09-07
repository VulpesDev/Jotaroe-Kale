using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene1 : MonoBehaviour
{
    public void LoadNextScene()
    {
        GameObject.Find("LevelLoader").GetComponent<LevelLoader>().LoadNextScene();

    }
    public void Yawn()
    {
        GameObject.Find("Yawn").GetComponent<AudioSource>().Play();
    }    
    public void Growl()
    {
        GameObject.Find("Growl").GetComponent<AudioSource>().Play();
    }
    public void Ring()
    {
        GameObject.Find("Ring").GetComponent<AudioSource>().Play();
    }
    public void BreakVase()
    {
        GameObject.Find("Break_vase").GetComponent<AudioSource>().Play();
    }
    public void Pistol1()
    {
        GameObject.Find("Pistol1").GetComponent<AudioSource>().Play();
    }
    public void Pistol2()
    {
        GameObject.Find("Pistol2").GetComponent<AudioSource>().Play();
    }
    public void Woosh()
    {
        GameObject.Find("Woosh").GetComponent<AudioSource>().Play();
    }
    public void Laugh()
    {
        GameObject.Find("Laugh").GetComponent<AudioSource>().Play();
    }
    public void ThroatClean()
    {
        GameObject.Find("ThroatClean").GetComponent<AudioSource>().Play();
    }
    public void startMusic3()
    {
        GameObject.Find("Music2").GetComponent<AudioSource>().Stop();
        GameObject.Find("Music3").GetComponent<AudioSource>().Play();
    }
    public void Breathe()
    {
        GameObject.Find("Human").GetComponent<AudioSource>().Play();
    }
    
}
