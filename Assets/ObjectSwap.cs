using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwap : MonoBehaviour
{

    public GameObject MovableObject1;
    public GameObject MovableObject2;
    public Vector3 tempPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
    }

    private void Swap()
    {
        tempPosition = MovableObject1.transform.position;
        MovableObject1.transform.position = MovableObject2.transform.position;
        MovableObject2.transform.position = tempPosition;
    }
}
