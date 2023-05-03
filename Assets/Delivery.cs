using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float packageDestroyDelay = 1f;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collision detected!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Picked up package!");
            Destroy(other.gameObject, packageDestroyDelay);
            hasPackage = true;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
        }
    }

}
