using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    public Transform ninja;
    public Animator animator;

    private float y_velocity = 0f;
    public float G = -1f;
    public float jumpfactor = 0.1f;
    private Vector3 initial_position;

    private void Start()
    {
        initial_position = ninja.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Mathf.Approximately(initial_position.y, ninja.position.y))
        {
            Debug.Log("clicked");
            y_velocity = jumpfactor;
            animator.SetTrigger("JumpTrigger");
        }

        y_velocity += G * Time.deltaTime;

        Vector3 new_position = new Vector3(initial_position.x, Mathf.Max(initial_position.y, ninja.position.y + y_velocity), initial_position.z);

        ninja.position = new_position;
    }
}
