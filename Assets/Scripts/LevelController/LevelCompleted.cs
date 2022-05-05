using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameObject.FindGameObjectWithTag("Lvl1Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 3);
                SceneManager.LoadScene(5);
            }
            else if (GameObject.FindGameObjectWithTag("Lvl2Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 4);
                SceneManager.LoadScene(6);
            }
            else if (GameObject.FindGameObjectWithTag("Lvl3Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 5);
                SceneManager.LoadScene(7);
            }
            else if (GameObject.FindGameObjectWithTag("Lvl4Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 6);
                SceneManager.LoadScene(8);
            }
            else if (GameObject.FindGameObjectWithTag("Lvl5Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 7);
                SceneManager.LoadScene(9);
            }
            else if (GameObject.FindGameObjectWithTag("Lvl6Completed"))
            {
                PlayerPrefs.SetInt("reachedLevel", 8);
                SceneManager.LoadScene(10);
            }
        }
    }
}
