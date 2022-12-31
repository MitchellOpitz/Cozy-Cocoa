using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHighScores : MonoBehaviour
{
    public string playerPrefName;
    public TMP_Text TMP;
    public bool needsDollarSign;

    // Start is called before the first frame update
    void Awake()
    {
        if (needsDollarSign)
        {
            TMP.text = "$" + PlayerPrefs.GetInt(playerPrefName).ToString();
        }
        else
        {
            TMP.text = PlayerPrefs.GetInt(playerPrefName).ToString();
        }
    }
}
