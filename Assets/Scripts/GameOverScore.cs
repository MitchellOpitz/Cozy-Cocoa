using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public int score;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = UpdateMoney.totalEarned;
        text.text = "You earned $" + score;
    }
}
