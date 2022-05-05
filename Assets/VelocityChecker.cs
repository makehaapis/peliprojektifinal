using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityChecker : MonoBehaviour
{
    float previous;
    Transform trans;
    SpriteRenderer sr;
    private void Start()
    {
        trans = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        previous = trans.position.x;
    }
    void LateUpdate()
     {
        if(previous > trans.position.x)
        {
            print("moving left");
            sr.flipX = true;
        }
        else
        {
            print("moving right");
            sr.flipX = true;
        }
        previous = trans.position.x;
    }
}