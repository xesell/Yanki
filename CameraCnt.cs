using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCnt : MonoBehaviour
{
    public GameObject camera;
    private float speed = 0.5f;
    private Vector3 target;


    // private Vector2 cklick;

    private void Start()
    {
        target = camera.transform.position;
    }

    void Update()
    {
        //    if (Input.touchCount > 0) Swipe();
    }

    private void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case ("Up"):
                target.y = camera.transform.position.y+1;
                camera.transform.position = target;
                break;
            case ("Down"):
                target.y = camera.transform.position.y-1;
                camera.transform.position = target;
                break;
            case ("Left"):
                target.x = camera.transform.position.x-1;
                camera.transform.position = target;
                break;
            case ("Right"):
                target.x = camera.transform.position.x+1;
                camera.transform.position = target;
                break;

        }
    }

    void Swipe() {
        Vector2 delta = Input.GetTouch(0).deltaPosition;

        if (Mathf.Abs(delta.x) > (Mathf.Abs(delta.y)))
        {

            if (delta.x > 0)
            {
                Debug.Log("Right");
            }
            else
            {
                Debug.Log("Right");
            }
        }
        else { 
        if(delta.y>0) Debug.Log("Up");
            else Debug.Log("Down");

        }
    }
}
