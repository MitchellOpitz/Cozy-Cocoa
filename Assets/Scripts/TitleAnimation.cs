using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnimation : MonoBehaviour
{
    private float timeElasped;
    public GameObject titleOn;

    // Start is called before the first frame update
    void Start()
    {
        timeElasped = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeElasped += Time.deltaTime;
        if (timeElasped > 1f)
        {
            titleOn.SetActive(!titleOn.activeSelf);
            timeElasped = 0;
        }
    }
}
