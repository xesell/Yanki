using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public Sprite spOne, spTwo, spThree;
    private int Rand;
    private int countRes;
    public bool life;

    void Start()
    {
        RandSprite();
        GetComponent<Renderer>().sortingOrder = -(int)transform.position.y;
        countRes = 4;
        life = true;
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
    public bool ResUse() {
       
        countRes = countRes - 2;
        if (countRes <= 0) return false;

        return true;
    }
        
}
