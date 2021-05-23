using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvLSystem : MonoBehaviour
{
    // Level
    public static float level = 1;
    public static float exp;
    public static float expToNextLevel = 5;
    public static float num;
    public Text levelText;
    public Text expLeftToNextLvl;

    // Update is called once per frame
    void Update()
    {
        if (exp >= expToNextLevel)
        {
            level++;
            exp = 0;
            expToNextLevel *= 2;

        }

        num = expToNextLevel - exp;

        levelText.text = level + " Level";
        expLeftToNextLvl.text = num + " exp left";
    }
}
