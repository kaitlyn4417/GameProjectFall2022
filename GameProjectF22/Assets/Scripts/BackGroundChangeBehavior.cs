using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundChangeBehavior : MonoBehaviour
{
    public GameObject ingredientsBG;
    public GameObject bakeBG;
    public GameObject decorateBG;

    public void ChangeBackground()
    {
        if (ingredientsBG.active)
        {
            ingredientsBG.SetActive(false);
            bakeBG.SetActive(true);
        }
        else if (bakeBG.active)
        {
            bakeBG.SetActive(false);
            decorateBG.SetActive(true);
        }
    }
}
