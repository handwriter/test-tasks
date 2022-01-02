using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewTwo : MonoBehaviour
{
    public GameObject spawnPoint;
    public Text inputDistance;
    public Text inputSpeed;
    public Text inputSpawnTimeout;

    public void OnDistanceChanged()
    {
        int parsedValue;
        if (int.TryParse(inputDistance.text, out parsedValue))
        {
            ApplicationTwo.getInstance().model.distance = parsedValue;
        }
    }

    public void OnSpeedChanged()
    {
        int parsedValue;
        if (int.TryParse(inputSpeed.text, out parsedValue))
        {
            ApplicationTwo.getInstance().model.speed = parsedValue;
        }
    }

    public void OnSpawnTimeoutChanged()
    {
        int parsedValue;
        if (int.TryParse(inputSpawnTimeout.text, out parsedValue))
        {
            ApplicationTwo.getInstance().model.spawnTimeout = parsedValue;
        }
    }
}
