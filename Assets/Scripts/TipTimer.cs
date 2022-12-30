using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipTimer : MonoBehaviour
{
    public Image tipTimer;
    public float maxTime = 5f;
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
            tipTimer.fillAmount = timeRemaining / maxTime;
        } else
        {
            tipTimer.fillAmount = 0;
        }
    }

    public void ResetTimer()
    {
        timeRemaining = maxTime;
    }
}
