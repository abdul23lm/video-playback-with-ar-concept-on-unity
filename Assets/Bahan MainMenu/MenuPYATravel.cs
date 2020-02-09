using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPYATravel : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject AboutPanel;
    public GameObject PetunjukPanel;
    public GameObject WisataPanel;
    public GameObject CVGPanel;
    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(false);
        CVGPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WisataButtonClicked()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(true);
        CVGPanel.SetActive(false);
    }
    public void AboutButtonClicked()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(true);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(false);
        CVGPanel.SetActive(false);
    }
    public void PetunjukButtonClicked()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(true);
        WisataPanel.SetActive(false);
        CVGPanel.SetActive(false);
    }
    public void CVGButtonClicked()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(false);
        CVGPanel.SetActive(true);
    }
    public void ScanButtonClicked()
    {
        Application.LoadLevel("ARVideo");
    }
    public void GetImageButtonClicked()
    {
        Application.OpenURL("https://drive.google.com/file/d/1jdpQfPq8WqToDY-WZRujG6YY0ZLu20kK/view?usp=sharing");
    }
    public void Keluar_Clicked()
    {
        Application.Quit();
    }
    public void BackButtonClicked()
    {
        MainPanel.SetActive(true);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(false);
        CVGPanel.SetActive(false);
    }
    public void BackButton2Clicked()
    {
        MainPanel.SetActive(false);
        AboutPanel.SetActive(false);
        PetunjukPanel.SetActive(false);
        WisataPanel.SetActive(true);
        CVGPanel.SetActive(false);
    }
}
