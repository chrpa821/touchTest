using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
  public GameObject objectToInstantiate;
 private GameObject myCurrentObject;

void Start(){




}

  void Update(){

    RaycastHit hit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

     if (Physics.Raycast(ray, out hit)){




    if(Input.GetMouseButtonDown(0)){
      myCurrentObject = Instantiate(objectToInstantiate, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 17f)), Quaternion.identity);
      print("hej");
     }
     if(Input.GetMouseButton(0) && myCurrentObject){
      myCurrentObject.transform.position =  Camera.main.ScreenToWorldPoint(Input.mousePosition);

     }
     if(Input.GetMouseButtonUp(0) && myCurrentObject){
       myCurrentObject = null;
       print("då");
     }
   }
 }
}
