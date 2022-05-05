using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oviaukeaa : MonoBehaviour
{
    public GameObject ovi;
    public GameObject nappi;

    void Start()
    {
        nappi.SetActive(true);
        ovi.SetActive(true);
    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            nappi.SetActive(false);
            ovi.SetActive(false);
        }
    }
}
