using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject Yanki;
    GameObject[] Yankes = new GameObject[40];
    public GameObject Tree;
    public GameObject[] Trees;
    public GameObject MineO;
    public GameObject[] Mines;
    
    Vector3 Rand;
    private int  RandX, RandY, RandThe;

    public int Food = 0, Wood = 0, Mine = 0;
    int countYanki = 0;
    int MaxYanki = 5;

    public int YankiFood = 1;
    public int YankiWood = 1;
    public int YankiMine = 1;


    void Start()
    {
        TreesCountControler();
        MineCountControler();
        YankiInit();
      

    }

    void Update()
    {
        TreesCountControler();
        MineCountControler();
    }

    void TreesCountControler()
    {
        for (int i = 0; i < Trees.Length; i++) {
            if (Trees[i] == null) {
                ResRandomPosition();
                Trees[i] = Instantiate(Tree, Rand, Quaternion.identity) as GameObject;
            }
        }
    }
    void MineCountControler()
    {
        for (int i = 0; i < Mines.Length; i++)
        {
            if (Mines[i] == null)
            {
                ResRandomPosition();
                Mines[i] = Instantiate(MineO, Rand, Quaternion.identity) as GameObject;
            }
        }
    }

    void ResRandomPosition() {
        while(true){
            RandX = Random.Range(-21, 21);
            RandY = Random.Range(-11, 11);
            if (RandX > 1 || RandX < -4 && RandY > 5 || RandY < -5)
            {
                Rand = new Vector3(RandX, RandY, 0);
                break;
            } }
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
    public global::Yanki.View RandomYankiView()
    {
        RandThe = Random.Range(1, 100);

        if(countYanki <= 1)
            return global::Yanki.View.YankiFood;
        else if (RandThe <= 60)
            return global::Yanki.View.YankiFood;
        else if (RandThe >= 61 && RandThe <= 90)
            return global::Yanki.View.YankiWood;
        else if (RandThe > 90)
            return global::Yanki.View.YankiMine;

        return global::Yanki.View.YankiFood;
    }

}
