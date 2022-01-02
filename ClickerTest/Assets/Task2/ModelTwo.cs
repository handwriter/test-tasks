using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelTwo : MonoBehaviour
{
    public Vector3 spawnCoords { get => ApplicationTwo.getInstance().view.spawnPoint.transform.position;}
    public int distance;
    public int speed;
    public int spawnTimeout;
    public GameObject cubePrefab;
}
