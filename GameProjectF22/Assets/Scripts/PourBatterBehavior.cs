using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourBatterBehavior : MonoBehaviour
{
    public SpriteRenderer pan;
    public Sprite panFull;

    private void OnTriggerEnter(Collider other)
    {
        pan.sprite = panFull;
    }

}
