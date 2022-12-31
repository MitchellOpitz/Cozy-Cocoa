using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoney : MonoBehaviour
{
    public static int totalEarned;
    public Text UItext;

    private void Start()
    {
        totalEarned = 0;
    }

    public void AddMoney (int income)
    {
        totalEarned += income;
        UItext.text = "Money: $" + totalEarned;
    }
}
