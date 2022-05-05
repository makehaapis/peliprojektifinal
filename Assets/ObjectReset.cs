using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReset : MonoBehaviour
{

    private Vector3 objectReset;
    public GameObject MovableObject;

    // Start is called before the first frame update
    void Start()
    {
        objectReset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            MovableObject.transform.position = objectReset;
        }
    }
}
