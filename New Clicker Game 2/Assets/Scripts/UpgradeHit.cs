using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeHit : MonoBehaviour
{
    // Upgrade Hit Button
    public static int upgradePrize;
    public Text upgradeText;
    
    // Update is called once per frame
    void Update()
    {
        // Upgrate Hit Button
        upgradeText.text = "Sword Upgrade Cost: " + upgradePrize + " $";
    }

    // Upgrade Hit Button
    public void Upgrade()
    {
        if (Game.currentScore >= upgradePrize)
        {
            Game.currentScore -= upgradePrize;
            Game.clickPower *= 2;
            upgradePrize *= 3;

        }
    }
}
