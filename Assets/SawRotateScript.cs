using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotateScript : MonoBehaviour
{

    private Rigidbody2D saw;
    // Start is called before the first frame update
    void Start()
    {
        saw = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        saw.transform.Rotate(Vector3.forward);
    }
}
