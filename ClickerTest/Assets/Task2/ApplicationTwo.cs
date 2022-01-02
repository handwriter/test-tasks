using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationTwo : MonoBehaviour
{
    private static ApplicationTwo instance;
    public ModelTwo model;
    public ViewTwo view;
    public ControllerTwo controller;

    public static ApplicationTwo getInstance()
    {
        if (instance == null)
        {
            instance = GameObject.Find("app").GetComponent<ApplicationTwo>();
        }
        return instance;
    }
}
