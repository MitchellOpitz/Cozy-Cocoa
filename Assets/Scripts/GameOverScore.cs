using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public int customers;
    public int score;
    public int tips;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        customers = UpdateMoney.customersServed;
        score = UpdateMoney.totalEarned;
        tips = UpdateMoney.tipsEarned;
        text.text = "You earned $" + score;
        UpdateHighScores();
    }

    void UpdateHighScores()
    {
        PlayerPrefs.SetInt("totalCustomers", PlayerPrefs.GetInt("totalCustomers") + customers);
        PlayerPrefs.SetInt("totalMoney", PlayerPrefs.GetInt("totalMoney") + score);
        PlayerPrefs.SetInt("totalTips", PlayerPrefs.GetInt("totalTips") + tips);

        if (tips > PlayerPrefs.GetInt("highestTips"))
        {
            PlayerPrefs.SetInt("highestTips", tips);
        }

        if (tips > PlayerPrefs.GetInt("highestMoney"))
        {
            PlayerPrefs.SetInt("highestMoney", score);
        }
    }
}