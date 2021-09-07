using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public static TextMeshProUGUI Subtittles;

    public bool Selected;

    public int index;
    string[] Descriptions = new string[32];
    GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = transform.GetChild(1).gameObject;
        Subtittles = GameObject.Find("Subtittles").GetComponent<TextMeshProUGUI>();
        map_descriptions();
    }

    public static IEnumerator ClearText()
    {
        yield return new WaitForSeconds(2f);
        Subtittles.text = "";
        Item.Subtittles.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.currentResolution.width == 2560)
        {
            Subtittles.rectTransform.sizeDelta = new Vector2(Screen.currentResolution.width - 0.35f * Screen.currentResolution.width, 80f);
        }
        else
        {
            Subtittles.rectTransform.sizeDelta = new Vector2(Screen.currentResolution.width - 0.1f * Screen.currentResolution.width, 80f);
        }
        if (Input.GetKeyDown(KeyCode.Q) && Selected)
        {
            if (CheckSelected.Check())
                Subtittles.text = Descriptions[index];
            else
            {
                Subtittles.text = "Select only one item";
                StartCoroutine(ClearText());
            }
        }
        if(Input.GetKeyDown(KeyCode.E) && Selected)
        {
            if(!CheckSelected.Check()){
                Subtittles.text = "Select only one item";
                StartCoroutine(ClearText());
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Light"))
        {
            Selected = true;
            transform.GetChild(0).gameObject.SetActive(true);
            text.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Light"))
        {
            Selected = false;
            Subtittles.text = "";
            transform.GetChild(0).gameObject.SetActive(false);
            text.SetActive(false);
        }
    }
    void map_descriptions()
    {
        Descriptions[0] = "That's white-out. Randomly left on the table. I don't think that's what Ricardo wants";   
        Descriptions[1] = "It appears the box is empty";   
        Descriptions[2] = "That's a bottle of wine. It has some wine left in it. You can see the lip marks on the edge of the bottle. It was used recently. Does Ricardo look like an alcoholic?";   
        Descriptions[3] = "Brand new toothbrush. The average person spends about 48 seconds per day brushing teeth, however the recommended time is 2 - 3 minutes. What type of person is this Ricardo?";   
        Descriptions[4] = "A wooden bowl. Looks like it's made from walnut wood from China and polished with Danish oil. Very vintage workmanship.";   
        Descriptions[5] = "'Gadsby by Ernest Vincent Wright'. I read that once. It's a 50,000 word novel that doesn't use the letter 'e'. Ricardo likes books?";   
        Descriptions[6] = "It's a box but in there it's a shampoo bottle";   
        Descriptions[7] = "Maybe Rodrigo's favourite thing is to keep himself clean?";   
        Descriptions[8] = "'Dancing Lessons for the Advanced in Age by Bohumil Hrabal'. Hmm.. the whole book is one giant run-on sentence... That's odd.";   
        Descriptions[9] = "It's very old. One of the gears is slightly broken and it skips turns. Time goes faster for this clock.";   
        Descriptions[10] = "Maybe a present from someone? Does Ricardo has any friends?";   
        Descriptions[11] = "He has a lot of them, this cannot be his favourite thing.";   
        Descriptions[12] = "Some old lether shoes with a sewn red fabric from Nigeria.";   
        Descriptions[13] = "It's Ricardo and his father... His father is wearing some lether shoes with a sewn red cloth. There is some dog on the side... looks like Peruvian Inca Orchid breed. It's very rare.";   
        Descriptions[14] = "It's some dead dog's collar. It says 'Francisco'.";   
        Descriptions[15] = "It's a photo album. Maybe he treasures his memories the most?";   
        Descriptions[16] = "Was he a good pool player?";   
        Descriptions[17] = "It's a very expensive golden ring with  11.1632-carat pear shaped diamond. It's FL quality. It's maybe the only diamond in the world with those charateristics. For price... I'm not sure.. maybe 2 to 4 million dolars.";   
        Descriptions[18] = "Basic playing cards pack with the letter 'R' written on the inside of the box with permanent marker, it's very dry and scratched, it's not from recently.";   
        Descriptions[19] = "Maybe there's something behind this outlet, only if I had a screwdriver";   
        Descriptions[20] = "It's beef. Maybe he just loves food? Oh wait, there's something inside the meat.";   
        Descriptions[21] = "That's 20's styled watch. It looks like it doesn't work anymore.";   
        Descriptions[22] = "A very fancy pen. It says 'Ricardo' with Italic Font on it.";   
        Descriptions[23] = "Some old radio working with batteries. Surprisingly it still works.";   
        Descriptions[24] = "Some unidenefied breed domestic species of small carnivorous mammal. In other words it's a cat . Looks like it's male.";   
        Descriptions[25] = "8 ball Pool trophy won at the 33th anniversery 8 ball pool competition.";   
        Descriptions[26] = "It's deer's head";   
        Descriptions[27] = "It's Beanfield Sniper Remington Sendero SF II with a heavy 26-inch barrel It weights 10 pounds. Isn't loaded.";   
        Descriptions[28] = "It's just an empty greeting card";   
        Descriptions[29] = "It's just an old rotary phone. Looks like the Western Electric model 500 telephone";
        Descriptions[30] = "Screwdriver. I don't think that's what Ricardo wants";
        Descriptions[31] = "Plastic bag, inside it there is 10 grams of heroin pills, the letter 'R' is carved in the pills. Maybe Ricardo is producing them. Using them?";
    }
}
