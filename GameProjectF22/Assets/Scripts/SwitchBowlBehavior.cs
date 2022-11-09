using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBowlBehavior : MonoBehaviour
{
	public SpriteRenderer bowl;
	public Sprite bowl2;

	private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Flour")
		{
			bowl.sprite = bowl2;
		}
		
    }
  
}
