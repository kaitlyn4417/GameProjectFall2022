using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBowlBehavior : MonoBehaviour
{
	public SpriteRenderer emptyBowl;
	public Sprite bowl2;
	public Sprite bowl3;
	public Sprite bowl4;
	private int ingredientCount = 0;

	private void OnTriggerEnter(Collider other)
    {
		ingredientCount++;
		if (ingredientCount == 4)
		{
			emptyBowl.sprite = bowl2;
		}
		
        if (ingredientCount == 8)
		{
			emptyBowl.sprite = bowl3;
		}
		
		if (ingredientCount >= 10)
		{
			emptyBowl.sprite = bowl4;
		}
    }
  
}
