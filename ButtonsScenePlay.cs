using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsScenePlay : MonoBehaviour
{
    public Sprite layer_pink, layer_white;
    private GameObject Home;
    public GameObject ImLost;


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
        GetComponent<SpriteRenderer>().sprite = layer_white;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_pink;
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name) {
            case ("Yanki+"):
            Home.GetComponent<Home>().YankiInit();
                break;
            case ("ImLost"):
              ImLost.SetActive(true);
                break;
          //  case ("Back"):
          //      Application.LoadLevel("play");
          //      break;
        }
    }
}
