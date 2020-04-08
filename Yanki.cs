using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yanki : MonoBehaviour
{
    public float speed;
    private GameObject Home; 
    private Vector3 target;
    private GameObject[] Trees;
    private Vector3 targetGo;

    private int numberTree;

    int food, wood, mine;

    void Start()
    {
        Home = GameObject.Find("Home");
        ResSelect();
    }

   
    void Update()
    {
        ResourceGathering();
        
    }
    void ResourceGathering() {
    transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    if (transform.position == target && target == targetGo)
    {
        target = Home.transform.position;
    }
    else if (transform.position == target && target == Home.transform.position)
    {
        ResSelect();
    }
    }
    void ResSelect() {
        Trees = Home.GetComponent<Home>().Trees;
        numberTree = Random.Range(0, Trees.Length);
        targetGo = Trees[numberTree].transform.position;
        target = targetGo;
        Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food + Home.GetComponent<Home>().YankiFood;
        
    }
}
