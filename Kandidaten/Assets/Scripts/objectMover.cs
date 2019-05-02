using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class objectMover : MonoBehaviour
{
  //public TurretBlueprint standardTurret;
  //public TurretBlueprint missileLauncher;
    public GameObject prefab1;
    public GameObject prefab2;
    private GameObject clone = null;


    void Start()
    {
      Shop shop = gameObject.GetComponent<Shop>();
    }

    // Update is called once per frame
    //void Update()
    void Update()
    {
        //for (var i = 0; i < Input.touchCount; ++i)
        //{
            //if (Input.GetTouch(i).phase == TouchPhase.Began)
            //{
                //Touch touch = Input.GetTouch(i);

                //RaycastHit hit;
                // Construct a ray from the current touch coordinates
                //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Create a particle if hit
              //  if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "TurretSpawner")

              //  {
              RaycastHit hit;
              Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
              if(Input.GetMouseButtonDown(0)){
                  if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.name == "colliderTurret"){
                      clone = (GameObject)Instantiate(prefab1, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 48f)), Quaternion.identity);

                      //Shop.selectStandardTurret();
                      //clone = (GameObject) Instantiate(standardTurret.prefab, new Vector3(0f,0f,0f), Quaternion.identity);
                  }

                  else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.name == "colliderTurret (1)"){
                      clone = Instantiate(prefab2, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 48f)), Quaternion.identity);
                  }
              }
              if(Input.GetMouseButton(0) && clone){
                  clone.transform.position =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 48f));
              }
              if(Input.GetMouseButtonUp(0) && clone){
                  if(Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "collider" )
                      Destroy(clone);
                  else
                      clone = null;
              }
                  //Turret = Instantiate(prefab, new Vector3(0f, 2f, 0f), Quaternion.identity);

                    //print(hit.transform.position);
                    //Turret.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 17.74f));

                //}
            /*}
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
        }*/
    }
}
