using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Shop
    public static int shop1Price = 25;   
    public Text shop1Text;

    public static int shop2Price = 125;
    public Text shop2Text;

    // Amount
    public Text amount1Text;
    public static int amount1 = 0;
    public static float amount1Profit = 1;

    public Text amount2Text;
    public static int amount2 = 0;
    public static float amount2Profit = 5;


    void Update()
    {
        // Shop 
        shop1Text.text = "Mining camp 1 upgrade: " + shop1Price + "$";
        shop2Text.text = "Mining camp 2 upgrade: " + shop2Price + "$";

        // Amount
        amount1Text.text = "Mining camp 1 makes: " + amount1 + "/sec";
        amount2Text.text = "Mining camp 2 makes: " + amount2 + "/sec";
    }

    // Shops
    public void Shop1()
    {
        if (Game.currentScore >= shop1Price)
        {
            Game.currentScore -= shop1Price;
            amount1 += 1;
            amount1Profit += 1;
            Game.x += 1;
            shop1Price *= 2;

        }
    }

    public void Shop2()
    {
        if (Game.currentScore >= shop2Price)
        {
            Game.currentScore -= shop2Price;
            amount2 += 5;
            amount2Profit += 5;
            Game.x += 5;
            shop2Price *= 2;

        }
    }
}
