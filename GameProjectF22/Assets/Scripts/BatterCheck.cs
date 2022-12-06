using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatterCheck : MonoBehaviour
{
    public UnityEvent nextPage;
    public GameObject pan1, panFull1, pan2, panFull2;
    public int value = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (pan1 = panFull1)
        {
            value++;
        }
        else if (pan2 = panFull2)
        {
            value++;
        }
    }

    private void CompareValue()
    {
        if (value == 2)
        {
            nextPage.Invoke();
        }
    }

}
