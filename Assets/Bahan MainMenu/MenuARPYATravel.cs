using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuARPYATravel : MonoBehaviour
{
    public GameObject ARPanel;

    // Start is called before the first frame update
    void Start()
    {
        ARPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackButtonARButtonClicked()
    {
        Application.LoadLevel("MainMenu");
    }
}
