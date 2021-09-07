using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GrabItem : MonoBehaviour
{
    public GameObject Heroin;
    bool Spawned = false;

    GameObject[] Collectables;
    GameObject[] inv =  new GameObject[3];
    [SerializeField] GameObject im1;
    [SerializeField] GameObject im2;
    [SerializeField] GameObject im3;
    TextMeshProUGUI ItemName1;
    TextMeshProUGUI ItemName2;
    TextMeshProUGUI ItemName3;
    public GameObject INVpanel;
    //resources folder for images !!!
    public GameObject Empty;

    public void Drop1()
    {
        inv[0].transform.position = transform.position;
        inv[0].SetActive(true);
        inv[0] = Empty;
    }
    public void Drop2()
    {
        inv[1].transform.position = transform.position;
        inv[1].SetActive(true);
        inv[1] = Empty;
    }
    public void Drop3()
    {
        inv[2].transform.position = transform.position;
        inv[2].SetActive(true);
        inv[2] = Empty;
    }

    void Start()
    {
        inv[0] = Empty;
        inv[1] = Empty;
        inv[2] = Empty;
        Collectables = GameObject.FindGameObjectsWithTag("IntItem");
        ItemName1 = im1.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        ItemName2 = im2.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        ItemName3 = im3.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        Heroin.SetActive(false);
    }

    public bool CheckIfOnlyOneItem()
    {
        if((inv[0].name == "Empty" && inv[1].name == "Empty") || (inv[1].name == "Empty" && inv[2].name == "Empty") || (inv[0].name == "Empty" && inv[2].name == "Empty"))
        {
            //check if Correct item
            return true;
        }
        else
        {
            //more than one item
            return false;
        }
    }
    public bool CheckIfCorrectItem()
    {
        if(inv[0].name == "Heroin" || inv[1].name == "Heroin" || inv[1].name == "Heroin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        if(ItemName1.text != inv[0].name || ItemName2.text != inv[1].name
            || ItemName3.text != inv[2].name)
        {
            ItemName1.text = inv[0].name;
            im1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Items/"+ inv[0].name);
            ItemName2.text = inv[1].name;
            im2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Items/" + inv[1].name);
            ItemName3.text = inv[2].name;
            im3.GetComponent<Image>().sprite = Resources.Load<Sprite>("Items/" + inv[2].name);
        }
        if (Input.GetKeyDown(KeyCode.E) && CheckSelected.Check())
        {
            for (int i = 0; i < Collectables.Length; i++)
            {
                if (Collectables[i].GetComponent<Item>().Selected)
                {
                    if (Collectables[i].GetComponent<Item>().index == 19)
                    {
                        if (!Spawned)
                        {
                            if (inv[0].name == "Screwdriver" || inv[1].name == "Screwdriver"
                                || inv[2].name == "Screwdriver")
                            {
                                Heroin.SetActive(true);
                                Spawned = true;
                            }
                        }
                    }
                    else
                    {

                        if (inv[0] == Empty)
                        {
                            inv[0] = Collectables[i];
                            inv[0].SetActive(false);
                        }
                        else if (inv[1] == Empty)
                        {
                            inv[1] = Collectables[i];
                            inv[1].SetActive(false);
                        }
                        else if (inv[2] == Empty)
                        {
                            inv[2] = Collectables[i];
                            inv[2].SetActive(false);
                        }
                        else
                        {
                            if (!INVpanel.active)
                            {
                                INVpanel.SetActive(true);
                            }
                            Item.Subtittles.color = Color.red;
                            Item.Subtittles.text =
                                "Drop something, in order to pick this item!(Open / Close inventory with 'I')";
                            StartCoroutine(Item.ClearText());
                        }
                    }
                    
                }
            }
        }
        //Debug
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(!INVpanel.active)
            {
                INVpanel.SetActive(true);
            }
            else
            {
                INVpanel.SetActive(false);
            }
        }
    }
}
