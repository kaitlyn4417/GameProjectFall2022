using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CounterBehavior : MonoBehaviour
{
    public int value;
	public int targetValue;
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
        
        if (value == targetValue)
        {
            nextPageEvent.Invoke();
        }
    }
    
}
