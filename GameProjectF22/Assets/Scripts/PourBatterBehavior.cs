using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PourBatterBehavior : MonoBehaviour
{
    public SpriteRenderer pan;
    public Sprite panFull;
	public UnityEvent nextPageEvent;

    private void OnTriggerEnter(Collider other)
    {
        pan.sprite = panFull;
		nextPageEvent.Invoke();
		
	}

}
