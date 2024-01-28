using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaSpawnController : MonoBehaviour
{
    public GameObject ninja;
    public float waitsecs = 1.5f;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitsecs);
        ninja.SetActive(true);
    }
}
