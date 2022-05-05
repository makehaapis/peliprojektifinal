using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siltakaatuu2 : MonoBehaviour
{
    public GameObject bridge;
    public GameObject button;

    void Start()
    {
        
    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(RotateMe(Vector3.forward * 90, 0.8f)); // forward | back | left | right
            button.transform.position = new Vector3(37, -10, 0);
        }
    }

    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            bridge.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
}
