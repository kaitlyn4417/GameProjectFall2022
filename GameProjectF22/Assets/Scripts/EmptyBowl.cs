using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBowl : MonoBehaviour
{
    public SpriteRenderer bowl;
    public Sprite emptyBowl;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Pan1" || other.gameObject.name == "Pan2")
        {
            bowl.sprite = emptyBowl;
        }
    }
}
