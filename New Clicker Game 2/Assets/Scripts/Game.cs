using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    
    public Text scoreText;
    public static float currentScore;
    public static float clickPower;
    public static float scoreIncresedPerSec;
    public static float x;

    // Plus anim
    public GameObject plusObject;
    public Text plusText;

    void Start()
    {

        currentScore = 0;
        clickPower = 1;
        scoreIncresedPerSec = 1;
        x = 0f;


        // Load

        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        clickPower = PlayerPrefs.GetInt("clickPower", 1);
        x = PlayerPrefs.GetInt("x", 0);

        Shop.shop1Price = PlayerPrefs.GetInt("shop1Price", 25);
        Shop.shop2Price = PlayerPrefs.GetInt("shop2Price", 125);
        Shop.amount1 = PlayerPrefs.GetInt("amount1");
        Shop.amount1Profit = PlayerPrefs.GetInt("amount1Profit", 0);
        Shop.amount2 = PlayerPrefs.GetInt("amount2");
        Shop.amount2Profit = PlayerPrefs.GetInt("amount2Profit", 0);
        UpgradeHit.upgradePrize = PlayerPrefs.GetInt("upgradePrize", 50);
        LvLSystem.level = PlayerPrefs.GetInt("level", 1);
        LvLSystem.exp = PlayerPrefs.GetInt("exp", 0);
        LvLSystem.num = PlayerPrefs.GetInt("num", 5);
        LvLSystem.expToNextLevel = PlayerPrefs.GetInt("expToNextLevel", 5);

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)currentScore + "$";
        scoreIncresedPerSec = x * Time.deltaTime;
        currentScore = currentScore + scoreIncresedPerSec;


        // Save
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("clickPower", (int)clickPower);
        PlayerPrefs.SetInt("x", (int)x);

        PlayerPrefs.SetInt("shop1Price", (int)Shop.shop1Price);
        PlayerPrefs.SetInt("shop2Price", (int)Shop.shop2Price);
        PlayerPrefs.SetInt("amount1", (int)Shop.amount1);
        PlayerPrefs.SetInt("amount1Profit", (int)Shop.amount1Profit);
        PlayerPrefs.SetInt("amount2", (int)Shop.amount2);
        PlayerPrefs.SetInt("amount2Profit", (int)Shop.amount2Profit);
        PlayerPrefs.SetInt("upgradePrize", (int)UpgradeHit.upgradePrize);
        PlayerPrefs.SetInt("level", (int)LvLSystem.level);
        PlayerPrefs.SetInt("exp", (int)LvLSystem.exp);
        PlayerPrefs.SetInt("num", (int)LvLSystem.num);
        PlayerPrefs.SetInt("expToNextLevel", (int)LvLSystem.expToNextLevel);


        // Plus anim
        plusText.text = "+ " + clickPower + "$";
    }



    // Hit function
    public void Hit()
    {
        currentScore += clickPower;

        // Exp
        LvLSystem.exp += clickPower;

        // Plus anim
        plusObject.SetActive(false);

        plusObject.transform.position = new Vector3(Random.Range(1000, 1150 + 1), Random.Range(405, 575 + 1), 0);

        plusObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Fly());


    }


    // Plus anim
    IEnumerator Fly()
    {
        for (int i = 0; i < 19; i++)
        {
            yield return new WaitForSeconds(0.01f);

            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y + 2, 0);
        }

        plusObject.SetActive(false);
    }


    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }
    
}
