using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBowl : MonoBehaviour
{
    public GameObject bowl;
    public void MoveBowlForBake()
    {
        bowl.transform.position = new Vector3(-7, -2, 0);
    }
}
