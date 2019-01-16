using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandle : MonoBehaviour {

    public static int points;

    // Use this for initialization
    void Start () {
        int points = 0;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "ball")
        {
            points++;
            Debug.Log(points);

        }
    }
}
