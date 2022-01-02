using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTwo : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        GameObject newCube = Instantiate(ApplicationTwo.getInstance().model.cubePrefab,
            ApplicationTwo.getInstance().view.transform);
        newCube.transform.position = ApplicationTwo.getInstance().model.spawnCoords;
        yield return new WaitForSeconds(ApplicationTwo.getInstance().model.spawnTimeout);
        yield return Spawn();
    }
}
