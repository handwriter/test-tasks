using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    private static Application instance;
    public Model model;
    public View view;
    public Controller controller;

    public static Application getInstance()
    {
        if (instance == null)
        {
            instance = GameObject.Find("app").GetComponent<Application>();
        }
        return instance;
    }
}
