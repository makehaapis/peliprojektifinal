using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool isRight = true;
    public float flyingspeed;
    private int health = 2;

    private Vector3 pointAPosition;
    private Vector3 pointBPosition;

    void Start()
    {
        pointAPosition = new Vector3(pointA.position.x, 0, 0);
        pointBPosition = new Vector3(pointB.position.x, 0, 0);
    }

    void Update()
    {
            Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
            if (isRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, pointB.position, flyingspeed * Time.deltaTime);
                if (thisPosition.Equals(pointBPosition))
                {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    isRight = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, pointA.position, flyingspeed * Time.deltaTime);
                if (thisPosition.Equals(pointAPosition))
                {
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                    isRight = true;
                }
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);

            health--;

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
