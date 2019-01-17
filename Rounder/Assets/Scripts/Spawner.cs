using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour {
    public int nextLevel;
    public int pointstowin;


	// Use this for initialization
	public void spawnBall()
    {
        //Debug.Log("ball spawned");
    }

    private void Update()
    {
        if(pointstowin == WinHandle.points)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

}
