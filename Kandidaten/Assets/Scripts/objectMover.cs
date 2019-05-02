using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class objectMover : MonoBehaviour
{
    public GameObject prefab;
    GameObject Turret;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(i);


                RaycastHit hit;
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Create a particle if hit
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "TurretSpawner")
                {

                    GameObject Turret = Instantiate(prefab, Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 15.74f)), Quaternion.identity);
                    //print(hit.transform.position);
                    //Turret.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 17.74f));

                    if (Input.GetTouch(i).phase == TouchPhase.Moved)
                    {
                        print("hje");
                    }

                }


            }
            else if (Input.GetTouch(i).phase == TouchPhase.Moved)
            {
                Touch touch = Input.GetTouch(i);


                RaycastHit hit;
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Create a particle if hit
                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "Turret1")
                {

                    //GameObject Turret = Instantiate(prefab, Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 17.74f)), Quaternion.identity);
                    //print(hit.transform.position);
                    hit.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 17.74f));

                }

            }
        }
    }
}
