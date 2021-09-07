using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResApply : MonoBehaviour
{
    int x, y;
    bool fullscreen;
    public void Apply()
    {
        x = int.Parse(GameObject.Find("x").GetComponent<TMP_InputField>().text);
        x = int.Parse(GameObject.Find("y").GetComponent<TMP_InputField>().text);
        fullscreen = GameObject.Find("Toggle").GetComponent<Toggle>().isOn;
        Screen.SetResolution(x, y, fullscreen);
    }
}
