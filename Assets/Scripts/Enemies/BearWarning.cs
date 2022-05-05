using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearWarning : MonoBehaviour
{
    public bool area;
    public GameObject uiElement_varoitus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (area == true)
        {
            uiElement_varoitus.SetActive(true);
        }
        else
        {
            uiElement_varoitus.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "KarhuVaroitus")
        {
            area = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "KarhuVaroitus")
        {
            area = false;
        }
    }
}
