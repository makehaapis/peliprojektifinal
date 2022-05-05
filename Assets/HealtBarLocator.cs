using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBarLocator : MonoBehaviour
{
    public GameObject player;

    public void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
