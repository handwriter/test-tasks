using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public Text counter;
    public void OnBtnClick()
    {
        Application.getInstance().controller.Click();
    }
}
