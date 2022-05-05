using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    private bool isKeyFollowing;

    public float followSpeed;
    public Transform followPlayer;

    void Start()
    {

    }


    void Update()
    {
        if(isKeyFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followPlayer.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(!isKeyFollowing)
            {
                Character thePlayer = FindObjectOfType<Character>();
                followPlayer = thePlayer.keyFollowPoint;
                isKeyFollowing = true;
                thePlayer.followingKey = this;
            }
        }
    }
}
