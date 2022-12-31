using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Image gameTimer;
    public float maxTime = 120f;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            gameTimer.fillAmount = timeRemaining / maxTime;
        }
        else
        {
            gameTimer.fillAmount = 0;
        }
    }
}
