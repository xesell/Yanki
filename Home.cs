using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject Yanki;
    GameObject[] Yankes = new GameObject[40];
    public GameObject Tree;
   public GameObject[] Trees;
    Vector3 Rand;

    public int Food = 0, Wood = 0, Mine = 0;
    int countYanki = 0;
    int MaxYanki = 5;

    public int YankiFood = 1;
    public int YankiWood = 1;
    public int YankiMine = 1;


    void Start()
    {
        TreesCountControler();
        YankiInit();
      

    }

    void Update()
    {
    
    }

    void TreesCountControler()
    {
        for (int i = 0; i < Trees.Length; i++) {
            if (Trees[i] == null) {
                Rand = new Vector3(Random.Range(-1,7),Random.Range(-3,3),0);
            Trees[i] = Instantiate(Tree, Rand, Quaternion.identity) as GameObject;
            }
        }
    }

    public void YankiInit() {

        if (countYanki < MaxYanki && Food >= 5)
        {      
            Food = Food - 5;
            countYanki = countYanki + 1;
            Yankes[countYanki] = Instantiate(Yanki, transform.position, Quaternion.identity) as GameObject;
        }
        else
        {
            Debug.Log("NoYanki");
        }  
    }

}
