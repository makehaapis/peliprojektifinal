using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearOpenPath : MonoBehaviour
{

    public GameObject door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bear")
        {
            Destroy(door);
        }
    }
}
