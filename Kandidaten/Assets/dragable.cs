using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragable : MonoBehaviour
{
    private int touches;

    void Start()
    {
        touches = Input.touchCount;
    }

    // Update is called once per frame
    void Update()
    {
           
        if(Input.touchCount > 0)
        {
            print(Input.touchCount);

            Touch touch = Input.GetTouch(touches);

           

            //if(touch.phase == TouchPhase.Began)
            //{
                print(new Vector3(touch.position.x, touch.position.y, 10f));
           // }
        }

    }
}
