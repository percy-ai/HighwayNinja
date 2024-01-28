using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaCollisionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
        }
    }

}
