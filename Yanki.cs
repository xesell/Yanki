using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yanki : MonoBehaviour
{
    public float speed;
    private GameObject Home; 
    private Vector3 target;
    private GameObject[] ResArray;
    private Vector3 targetGo;

    private int numberRes;

    private bool inHome;

    public Sprite YankiWood, YankiMine;
    public enum View { 
    YankiFood,
    YankiWood,
    YankiMine
    }
    public View ViewYanki;


    void Start()
    {
        Home = GameObject.Find("Home");
        ViewYanki = Home.GetComponent<Home>().RandomYankiView();
        if (ViewYanki == View.YankiFood)
        {
            ResSelectTree(true);
        }
        else if (ViewYanki == View.YankiWood) 
        {
            GetComponent<SpriteRenderer>().sprite = YankiWood;
            ResSelectTree(true);
        }
        else if (ViewYanki == View.YankiMine)
        {
            GetComponent<SpriteRenderer>().sprite = YankiMine;
            ResSelectMine(true);
        }
   
    }
    void Update()
    {
        if (ViewYanki == View.YankiFood || ViewYanki == View.YankiWood)
        {
            ResourceGatheringTree();
            YankiDestroyResDebag();
        }
        else if (ViewYanki == View.YankiMine) {
            ResourceGatheringMine();
            YankiDestroyResDebag();
        }
        
    }
    void ResourceGatheringTree() {
    transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    if (transform.position == target && target == targetGo)
    {
            if (!ResArray[numberRes].GetComponent<Tree>().ResUse())
            {
                Destroy(ResArray[numberRes]);
            }
        target = Home.transform.position;
            inHome = true;
    }
    else if (transform.position == target && target == Home.transform.position)
    {
        ResSelectTree(false);
            inHome = false;
    }
    }
    void ResSelectTree(bool start) {
        ResArray = Home.GetComponent<Home>().Trees;
        numberRes = Random.Range(0, ResArray.Length);
        targetGo = ResArray[numberRes].transform.position;
        target = targetGo;
        if (!start)
            if (ViewYanki == View.YankiFood)
            Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food + Home.GetComponent<Home>().YankiFood;
         else if(ViewYanki == View.YankiWood)
            Home.GetComponent<Home>().Wood = Home.GetComponent<Home>().Wood + Home.GetComponent<Home>().YankiWood;
    }

    void YankiDestroyResDebag() {
        if (targetGo != ResArray[numberRes].transform.position && !inHome) {
            if (ViewYanki == View.YankiFood || ViewYanki == View.YankiWood)
                ResSelectTree(false);
            else if (ViewYanki == View.YankiMine)
                ResSelectMine(false);
        }
    }

    void ResourceGatheringMine()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target == targetGo)
        {
            if (!ResArray[numberRes].GetComponent<Mine>().ResUse())
            {
                Destroy(ResArray[numberRes]);
            }
            target = Home.transform.position;
            inHome = true;
        }
        else if (transform.position == target && target == Home.transform.position)
        {
            ResSelectMine(false);
            inHome = false;
        }
    }
    void ResSelectMine(bool start)
    {
        ResArray = Home.GetComponent<Home>().Mines;
        numberRes = Random.Range(0, ResArray.Length);
        targetGo = ResArray[numberRes].transform.position;
        target = targetGo;
        if (!start)
           Home.GetComponent<Home>().Mine = Home.GetComponent<Home>().Mine + Home.GetComponent<Home>().YankiMine;
    }


}
