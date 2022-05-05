using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObjectTrigger : MonoBehaviour
{
    public GameObject door1;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RedObject")
        {
            door1.transform.position = new Vector3(52, -5, 0);
        }
    }
}
