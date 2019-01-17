using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandle : MonoBehaviour {

    public static int points;

    CircleCollider2D collider;
    // Use this for initialization
    void Start () {

        


        int points = 0;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "ball")
        {
            collider = col.GetComponent<CircleCollider2D>();
            collider.enabled = false;

            points++;

            FindObjectOfType<PlayerController>().scoredBall();

            Debug.Log(points);

        }
    }
}
