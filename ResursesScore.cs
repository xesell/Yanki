using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResursesScore : MonoBehaviour
{
    private GameObject Home;
    
    void Start()
    {
        Home = GameObject.Find("Home");
    }

   
    void Update()
    {
        NameScore();
    }
    void NameScore()
    {
        switch (gameObject.name)
        {
            case "Food":
                GetComponent<Text>().text = Home.GetComponent<Home>().Food.ToString();
                break;
            case "Wood":
                GetComponent<Text>().text = Home.GetComponent<Home>().Wood.ToString();
                break;
            case "Mine":
                GetComponent<Text>().text = Home.GetComponent<Home>().Mine.ToString();
                break;
        } }
}
