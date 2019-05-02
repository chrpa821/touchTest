using UnityEngine;
using System.Collections;

public class objectSpawner : MonoBehaviour {



	private Vector3 position;
	private float width;
	private float height;



	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.touchCount > 1) {
			Touch touch = Input.GetTouch(0);
            print("hej bästa");
            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Began) {
                print("hej bäst");
                //Vector2 pos = touch.position;


				//position = new Vector3 (pos.x, pos.y, 3.8f);


				// Position the cube.
				//transform.position = Camera.main.ScreenToWorldPoint(position);
			}
		}
	}
}