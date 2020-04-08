using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Sprite spOne, spTwo, spThree;
    private int Rand;

    void Start()
    {
        RandSprite();
        GetComponent<Renderer>().sortingOrder = -(int)transform.position.y;
    }


    void Update()
    {
     
    }
    void RandSprite()
    {
        Rand = Random.Range(0, 2);
        if(Rand == 0)
            GetComponent<SpriteRenderer>().sprite = spOne;
        else if (Rand == 1)
            GetComponent<SpriteRenderer>().sprite = spTwo;
        else if (Rand == 2)
            GetComponent<SpriteRenderer>().sprite = spThree;

    }
}
