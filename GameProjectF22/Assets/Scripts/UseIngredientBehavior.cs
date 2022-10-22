
using UnityEngine;
using UnityEngine.Events;

public class UseIngredientBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
