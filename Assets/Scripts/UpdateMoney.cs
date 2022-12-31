using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoney : MonoBehaviour
{
    public static int customersServed;
    public static int totalEarned;
    public static int tipsEarned;
    public Text UItext;

    private void Start()
    {
        totalEarned = 0;
        tipsEarned = 0;
    }

    public void AddMoney (int income)
    {
        customersServed++;
        totalEarned += income;
        if (income > 5)
        {
            tipsEarned += income - 5;
        }
        UItext.text = "Money: $" + totalEarned;
    }
}
