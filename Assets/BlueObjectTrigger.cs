using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueObjectTrigger : MonoBehaviour
{

    public GameObject door2;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BlueObject")
        {
            door2.transform.position = new Vector3(52, -5, 0);
        }
    }
}
