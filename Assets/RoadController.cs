using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public float userspeed;
    public List<Transform> roads;

    private float current_x = -25;
    private float next_x = -85.1f;

    private Transform current_road;
    private Transform next_road;

    public float acceleration = 1f;

    private void Start()
    {
        current_road = Instantiate(roads[0], new Vector3(-25, 0, 0), Quaternion.identity);
        next_road = Instantiate(roads[Random.Range(1, roads.Count)], new Vector3(-85.1f, 0, 0), Quaternion.identity);
        current_x = current_road.position.x;
    }

    private void Update()
    {
        float y = current_road.position.y;
        float z = current_road.position.z;

        userspeed += acceleration * Time.deltaTime;
        float speed = userspeed * Time.deltaTime;

        Vector3 new_position = new Vector3(current_x + speed, y, z);
        Vector3 new_next_position = new Vector3(next_x + speed, y, z);

        current_road.position = new_position;
        next_road.position = new_next_position;

        current_x += speed;
        next_x += speed;

        if (current_x >= 30f)
        {
            Debug.Log("yada");
            Destroy(current_road.gameObject);
            current_road = next_road;
            current_x = next_x;

            next_road = Instantiate(roads[Random.Range(1, roads.Count)], new Vector3(-90f, 0, 0), Quaternion.identity);
            next_x = -90f;
        }
    }
}
