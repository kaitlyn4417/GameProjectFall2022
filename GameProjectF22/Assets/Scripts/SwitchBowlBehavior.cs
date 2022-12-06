using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBowlBehavior : MonoBehaviour
{
	public SpriteRenderer emptyBowl;
	public Sprite bowl2;
	public Sprite bowl3;

	private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Flour")
		{
			emptyBowl.sprite = bowl2;
		}
		
        if (other.name == "Milk")
		{
			emptyBowl.sprite = bowl3;
		}
    }
  
}
