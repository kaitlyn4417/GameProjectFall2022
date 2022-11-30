using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BakeCounterBehavior : MonoBehaviour
{
    public int value;
    public UnityEvent startEvent, triggerEnterEvent, nextPageEvent;

    private void onStart()
    {
        startEvent.Invoke();
        value = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        value++;
        
        if (value == 3)
        {
            nextPageEvent.Invoke();
        }
    }
}
