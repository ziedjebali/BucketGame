using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotationSpeed = 10f;
    public Transform spawnPoint;
    public GameObject ball;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {


        float rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;

        

        rotation *= Time.deltaTime;

        // Rotate around our y-axis
        transform.Rotate(0, 0, rotation);


        Vector2 mousePos = new Vector2();
        mousePos.y = Input.mousePosition.y;

        mousePos.x = Input.mousePosition.x;

        if (Input.GetMouseButtonDown(0))
        {
            if(mousePos.y < 200)
            {
                Instantiate(ball, spawnPoint.position, transform.rotation);
            }
        }

        if (Input.GetMouseButton(0) )
        {
            if (mousePos.x < 300 && mousePos.y > 200)
            {
                transform.Rotate(0, 0, -rotationSpeed*Time.deltaTime);

            } else if(mousePos.x > 300 && mousePos.y > 200)
            {
                transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            }

            //Debug.Log(mousePos);
        }
    }
}
