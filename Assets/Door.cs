using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Character thePlayer;

    //public SpriteRenderer theSR;
    //public Sprite doorOpenSprite;

    public GameObject theDoor;

    public bool doorOpen;
    public bool waitingToOpen;

    void Start()
    {
        thePlayer = FindObjectOfType<Character>();
    }


    void Update()
    {
        if(waitingToOpen)
        {
            if(Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) <0.1f)
            {
                waitingToOpen = false;

                doorOpen = true;

                theDoor.transform.position = new Vector3(10, -4, 0);

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followPlayer = transform;
                waitingToOpen = true;
            }
        }
    }
}
