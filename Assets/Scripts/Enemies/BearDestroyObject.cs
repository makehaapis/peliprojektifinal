using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearDestroyObject : MonoBehaviour
{

    public GameObject block;
    public Animator animator;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bear")
        {
            print("karhu osuu");
            StartCoroutine(DestroyObject());
        }
    }

    private IEnumerator DestroyObject()
    {
        animator.SetBool("Destroy", true);
        yield return new WaitForSeconds(0.4f);
        Destroy(block);
    }
}
