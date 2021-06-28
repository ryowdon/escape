using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject sofa;
    public GameObject cushion;

    public void MoveSofa()
    {
        sofa.transform.localPosition = new Vector2(240, -30);
    }

    public void MoveCushion()
    {
        cushion.transform.localPosition = new Vector2(72, 15);
    }
}