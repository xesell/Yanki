using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsImprov : MonoBehaviour
{
    private GameObject Home;
    public GameObject ImLost;
    private bool bay = false;
    private int lvl=0;
    public Sprite onelvl, twolvl, treelvl;

    void Start()
    {
        Home = GameObject.Find("Home");
        Home = GameObject.FindGameObjectWithTag("Method");

    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
    }
    private void OnMouseUp()
    {
    }
    private void OnMouseUpAsButton()
    {       
        switch (gameObject.name) {
            case ("Back"):
                ImLost.SetActive(false);
                break;
            case ("YankiFood+"):
                if (lvl == 0 && Home.GetComponent<Home>().Food >= 10)
                {
                    Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food - 10;
                    Home.GetComponent<Home>().YankiFood = 2;
                    lvl++;

                }
                else if (lvl == 1 && Home.GetComponent<Home>().Wood >= 20) {
                    Home.GetComponent<Home>().Wood = Home.GetComponent<Home>().Wood - 20;
                    Home.GetComponent<Home>().YankiFood = 5;
                    lvl++;
                }
                else if (lvl == 2 && Home.GetComponent<Home>().Mine >= 50) {
                    Home.GetComponent<Home>().Mine = Home.GetComponent<Home>().Mine - 50;
                    Home.GetComponent<Home>().YankiFood = 10;
                    bay = true;
                }
                    break;
            case ("YankiWood+"):
                if (lvl == 0 && Home.GetComponent<Home>().Food >= 50)
                {
                    Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food - 50;
                    Home.GetComponent<Home>().YankiWood = 2;
                    lvl++;

                }
                else if (lvl == 1 && Home.GetComponent<Home>().Mine >= 30)
                {
                    Home.GetComponent<Home>().Mine = Home.GetComponent<Home>().Mine - 30;
                    Home.GetComponent<Home>().YankiWood = 5;
                    lvl++;
                }
                else if (lvl == 2 && Home.GetComponent<Home>().Food >= 250)
                {
                    Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food - 250;
                    Home.GetComponent<Home>().YankiWood = 10;
                    bay = true;
                }
                break;
            case ("YankiMine+"):
                if (lvl == 0 && Home.GetComponent<Home>().Wood >= 50)
                {
                    Home.GetComponent<Home>().Wood = Home.GetComponent<Home>().Wood - 50;
                    Home.GetComponent<Home>().YankiMine = 2;
                    lvl++;

                }
                else if (lvl == 1 && Home.GetComponent<Home>().Food >= 250)
                {
                    Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food - 250;
                    Home.GetComponent<Home>().YankiMine = 5;
                    lvl++;
                }
                else if (lvl == 2 && Home.GetComponent<Home>().Wood >= 400)
                {
                    Home.GetComponent<Home>().Wood = Home.GetComponent<Home>().Wood - 400;
                    Home.GetComponent<Home>().YankiMine = 10;
                    bay = true;
                }
                break;
         
        }
    }
}
