using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PanelSwitching : MonoBehaviour
{
    public GameObject panel1, panel2, panel3;
    public void OpenPage1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
    public void OpenPage2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
    }
    public void OpenPage3()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
}
