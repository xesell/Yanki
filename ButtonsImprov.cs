using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsImprov : MonoBehaviour
{
    public Sprite layer_white, layer_purple;
    private GameObject Home;
    public GameObject ImLost;
    private bool bay = false;

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
        GetComponent<SpriteRenderer>().sprite = layer_purple;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_white;
    }
    private void OnMouseUpAsButton()
    {
        GetComponent<SpriteRenderer>().sprite = layer_white;
       
        switch (gameObject.name) {
            case ("Back"):
                ImLost.SetActive(false);
                break;
            case ("YankiFood+One"):
                if (!bay && Home.GetComponent<Home>().Food>=5)
                {
                    bay = true;
                    Home.GetComponent<Home>().Food = Home.GetComponent<Home>().Food - 5;
                    Debug.Log("Food+");
                    Home.GetComponent<Home>().YankiFood = 2;
                }
                break;
            case ("YankiFood+Two"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiFood = 5;
                    bay = true;
                }
                break;
            case ("YankiFood+Three"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiFood = 10;
                    bay = true;
                }
                break;
            case ("YankiWood+One"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiWood = 2;
                    bay = true;
                }
                break;
            case ("YankiWood+Two"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiWood = 5;
                    bay = true;
                }
                break;
            case ("YankiWood+Three"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiWood = 10;
                    bay = true;
                }
                break;
            case ("YankiMine+One"):
                if (!bay) {
                    Home.GetComponent<Home>().YankiWood = 2;
                    bay = true;
                }
                break;
            case ("YankiMine+Two"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiWood = 5;
                    bay = true;
                }
                break;
            case ("YankiMine+Three"):
                if (!bay) { 
                    Home.GetComponent<Home>().YankiWood = 10;
                    bay = true;
                }
                break;
        }
    }
}
