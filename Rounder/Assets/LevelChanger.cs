using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public int BuildIndex;

    public void changeLevel()
    {
        SceneManager.LoadScene(BuildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        changeLevel();
    }
}
