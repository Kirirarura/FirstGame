using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guide : MonoBehaviour
{

    public GameObject guideText;
    
    void Start()
    {
        guideText.GetComponent<Text>().text = "Hi there!!! You are a new hero! I will guide you. Click on the monster in the center!";
    }

    void Update()
    {
        // Guide comments
        if (Game.currentScore >= Shop.shop1Price)
        {
            guideText.GetComponent<Text>().text = "Now you can upgrade first mine camp or other stuff on the right side of your screen, in the shop.";
        }
        if (Game.currentScore >= UpgradeHit.upgradePrize)
        {
            guideText.GetComponent<Text>().text = "Don't forget to upgrade your sword. More damage you do, more exp you gain.";
        }
        if (LvLSystem.level == 5)
        {
            guideText.GetComponent<Text>().text = "Good job. Now you have 5 lvl! Keep going.";
        }
        if (Game.currentScore >= Shop.shop2Price)
        {
            guideText.GetComponent<Text>().text = "Now you can upgrade second mine or other stuff.";
        }
        if (LvLSystem.level == 9)
        {
            guideText.GetComponent<Text>().text = "Unbelievable, you still playing in this game...";
        }
        if (LvLSystem.level == 12)
        {
            guideText.GetComponent<Text>().text = "Bro... find some 'good' games. Stop playing it a beta.";
        }
    }
}
