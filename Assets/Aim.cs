using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] Transform gunArm;
    float offset = -90;
    Vector3 location;
    Vector3 armlocation;

    void Start()
    {
        location = transform.localScale;
        armlocation = gunArm.localScale;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 perendicular = gunArm.position - mousePos;
        Quaternion val = Quaternion.LookRotation(Vector3.forward, perendicular);
        val *= Quaternion.Euler(0, 0, offset);
        gunArm.rotation = val;

        if (transform.position.x - mousePos.x < 0)
        {
            transform.localScale = location;
            gunArm.localScale = armlocation;
        }

        else if (transform.position.x - mousePos.x > 0)
        {
            transform.localScale = new Vector3(-location.x, location.y, location.z);
            gunArm.localScale = new Vector3(-armlocation.x, -armlocation.y, armlocation.z);
        }
    }
}
