using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagements : MonoBehaviour
{
    public bool colliding1;
    public bool colliding2;

    public GameObject uiElement_painaS;
    public GameObject uiElement_painaS_static;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && colliding1)
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKeyDown(KeyCode.S) && colliding2)
        {
            PlayerPrefs.SetInt("reachedLevel", 2);
            SceneManager.LoadScene(2);
        }

        // uiElement Ohjeet pelaajalle
        if (colliding1 == true)
        {
            uiElement_painaS.SetActive(true);
        }
        else
        {
            uiElement_painaS.SetActive(false);
        }

        if (colliding2 == true)
        {
            uiElement_painaS_static.SetActive(true);
        }
        else
        {
            uiElement_painaS_static.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Area1level1totalo")
        {
            colliding1 = true;
        }
        else if (collision.tag == "TalotoArea1level1")
        {
            colliding2 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Area1level1totalo")
        {
            colliding1 = false;
        }
        else if (collision.tag == "TalotoArea1level1")
        {
            colliding2 = false;
        }
    }
}
