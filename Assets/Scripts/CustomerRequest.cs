using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerRequest : MonoBehaviour
{
    public GameObject[] cocoaRequested;
    public GameObject[] cocoaMade;

    private void Start()
    {
        NewRequest();
    }

    private void OnMouseDown()
    {
        bool cocoaMatches = true;
        for (int i = 0; i < cocoaRequested.Length; i++)
        {
            if (cocoaRequested[i].activeSelf != cocoaMade[i].activeSelf)
            {
                cocoaMatches = false;
            }

        }

        if (cocoaMatches)
        {
            Debug.Log("Cocoa made does match request.");
            Debug.Log("Getting new customer.");
            NewRequest();
        } else
        {
            Debug.Log("Cocoa made does not match request.");
        }
    }

    void NewRequest()
    {
        ResetRequests();
        int marshmallowsOrWhippedCream = RollRandom();
        int whippedCreamToppings = RollRandom();
        int peppermint = RollRandom();

        // Cup and hot cocoa required
        cocoaRequested[0].SetActive(true);
        cocoaRequested[1].SetActive(true);

        // Plain
        if (marshmallowsOrWhippedCream < 10)
        {
            return;
        } 

        // Marshmallows
        else if (marshmallowsOrWhippedCream < 50)
        {
            cocoaRequested[6].SetActive(true);
        }

        // Whipped Cream
        else
        {
            cocoaRequested[2].SetActive(true);

            // Toppings

            // Plain
            if (whippedCreamToppings < 33)
            {
                return;
            }

            // Sprinkles
            else if (whippedCreamToppings < 66)
            {
                cocoaRequested[3].SetActive(true);
            }

            // Spices
            else
            {
                cocoaRequested[4].SetActive(true);
            }
        }

        // Peppermint
        if (peppermint < 50)
        {
            cocoaRequested[5].SetActive(true);
        }

    }

    void ResetRequests()
    {
        foreach(GameObject go in cocoaRequested)
        {
            go.SetActive(false);
        }
        foreach (GameObject go in cocoaMade)
        {
            go.SetActive(false);
        }
    }

    int RollRandom()
    {
        int randomNumber = Random.Range(0, 100);
        return randomNumber;
    }
}
