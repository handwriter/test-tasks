using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public void Click()
    {
        Application.getInstance().model.clickCount++;
        Application.getInstance().view.counter.text = Application.getInstance().model.clickCount.ToString();
    }
}
