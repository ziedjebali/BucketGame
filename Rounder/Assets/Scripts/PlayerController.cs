using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int leveldificulty;
    public static bool scored;
    public Transform[] ballstowin;

    public GameObject ballimage;

    int lastindex;

    public float rotationspeed = 10f;
    public Transform spawnpoint;
    public GameObject ball;


    // Use this for initialization
    void Start () {

        for (int i = 0; i < leveldificulty; i++)
        {
            GameObject ballsimage = Instantiate(ballimage, ballstowin[i].position, transform.rotation);
            ballsimage.transform.parent = ballstowin[i].transform;
        }

        lastindex = leveldificulty-1;

    }

    // Update is called once per frame
    void Update()
    {


        float rotation = Input.GetAxisRaw("Horizontal") * rotationspeed;

        

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
                Instantiate(ball, spawnpoint.position, transform.rotation);
            }
        }else if (Input.GetKeyDown("space")){

            Instantiate(ball, spawnpoint.position, transform.rotation);
            

        }

        if (Input.GetMouseButton(0) )
        {
            if (mousePos.x < 300 && mousePos.y > 200)
            {
                transform.Rotate(0, 0, -rotationspeed*Time.deltaTime);

            } else if(mousePos.x > 300 && mousePos.y > 200)
            {
                transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
            }

            //Debug.Log(mousePos);
        }
    }

    public  void scoredBall()
    {

        Destroy(ballstowin[lastindex].gameObject);
        lastindex--;
        scored = false;

    }
}
