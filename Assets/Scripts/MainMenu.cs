using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //{FOR MAIN MENU --START--}

    public void StartMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void StartSimulation()
    {
        SceneManager.LoadSceneAsync("LP1");
    }
    public void QuitSimulation()
    {
        Application.Quit();
    }
    //{FOR MAIN MENU --END--}


    //{FOR LANDING PAGE --START--}
    public void StartPA()
    {
        SceneManager.LoadSceneAsync("PA1");
    }

    public void StartRapid()
    {
        SceneManager.LoadSceneAsync("Rapid1");
    }

    //{FOR LANDING PAGE --END--}


    //{FOR PATIENT ASSESSMENT --START--}
    public void StartPatientassessment2()
    {
        SceneManager.LoadSceneAsync("PA2");
    }
    public void StartPatientassessment3and4()
    {
        SceneManager.LoadSceneAsync("PA3N4");
    }
    public void StartPatientassessment5()
    {
        SceneManager.LoadSceneAsync("PA5");
    }
    public void StartPatientassessment6()
    {
        SceneManager.LoadSceneAsync("PA6");
    }
    public void StartPatientassessment7()
    {
        SceneManager.LoadSceneAsync("PA7");
    }
    public void StartPatientassessment8_1()
    {
        SceneManager.LoadSceneAsync("PA8.1");
    }
    public void StartPatientassessment9_2()
    {
        SceneManager.LoadSceneAsync("PA9.2");
    }
    public void StartPatientassessment10_3()
    {
        SceneManager.LoadSceneAsync("PA10.3");
    }


    //{FOR PATIENT ASSESSMENT --END--}



    //{FOR RAPID EXTRICATION --START--}
    public void StartRapid2()
    {
        SceneManager.LoadSceneAsync("Rapid2");
    }
    public void StartRapid3()
    {
        SceneManager.LoadSceneAsync("Rapid3");
    }
    public void StartRapid4()
    {
        SceneManager.LoadSceneAsync("Rapid4");
    }
    public void StartRapid5()
    {
        SceneManager.LoadSceneAsync("Rapid5");
    }
    public void StartRapid5_6()
    {
        SceneManager.LoadSceneAsync("Rapid5_6");
    }
    public void StartRapid7()
    {
        SceneManager.LoadSceneAsync("Rapid7");
    }
    //{FOR RAPID EXTRICATION --END--}
}
