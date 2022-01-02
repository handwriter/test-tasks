using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private int distance;
    private int speed;
    private float progressDistance;
    void Start()
    {
        distance = ApplicationTwo.getInstance().model.distance;
        speed = ApplicationTwo.getInstance().model.speed;
    }

    void Update()
    {
        progressDistance += speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, progressDistance);
        if (progressDistance >= distance)
        {
            Destroy(gameObject);
        }
    }
}
