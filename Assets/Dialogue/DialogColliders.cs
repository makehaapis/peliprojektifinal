using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogColliders : MonoBehaviour
{
    public bool dialogColliding1;
    public bool dialogColliding2;
    public bool dialogColliding3;
    public bool dialogColliding4;
    public bool dialogColliding5;
    public bool dialogColliding6;
    public bool dialogColliding7;

    public GameObject UIElement_dialog1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogColliding1 == true || dialogColliding2 == true || dialogColliding3 == true || dialogColliding4 == true || dialogColliding5 == true || dialogColliding6 == true || dialogColliding7 == true)
        {
            UIElement_dialog1.SetActive(true);
        }
        else if (dialogColliding1 == false || dialogColliding2 == false || dialogColliding3 == false || dialogColliding4 == false || dialogColliding5 == false || dialogColliding6 == false || dialogColliding7 == false)
        {
            UIElement_dialog1.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Info1")
        {
            dialogColliding1 = true;
        }
        else if(collision.tag == "Info2")
        {
            dialogColliding2 = true;
        }
        else if (collision.tag == "Info3")
        {
            dialogColliding3 = true;
        }
        else if (collision.tag == "Info4")
        {
            dialogColliding4 = true;
        }
        else if (collision.tag == "Info5")
        {
            dialogColliding5 = true;
        }
        else if (collision.tag == "Info6")
        {
            dialogColliding6 = true;
        }
        else if (collision.tag == "Info7")
        {
            dialogColliding7 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Info1")
        {
            dialogColliding1 = false;
        }
        else if (collision.tag == "Info2")
        {
            dialogColliding2 = false;
        }
        else if (collision.tag == "Info3")
        {
            dialogColliding3 = false;
        }
        else if (collision.tag == "Info4")
        {
            dialogColliding4 = false;
        }
        else if (collision.tag == "Info5")
        {
            dialogColliding5 = false;
        }
        else if (collision.tag == "Info6")
        {
            dialogColliding6 = false;
        }
        else if (collision.tag == "Info7")
        {
            dialogColliding7 = false;
        }
    }
}
