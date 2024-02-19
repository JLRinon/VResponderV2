using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private SceneTransitionManager transitionManager;

    private void Start()
    {
        // Find the SceneTransitionManager in the scene
        transitionManager = FindObjectOfType<SceneTransitionManager>();
    }

    //{FOR MAIN MENU --START--}

    public void StartMainMenu()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("MainMenu");
    }

    public void StartSimulation()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("LP1");
    }

    public void QuitSimulation()
    {
        // Quit the application
        Application.Quit();
    }

    //{FOR MAIN MENU --END--}


    //{FOR LANDING PAGE --START--}
    public void StartPA()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA1");
    }

    public void StartRapid()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid1");
    }

    //{FOR LANDING PAGE --END--}


    //{FOR PATIENT ASSESSMENT --START--}
    public void StartPatientassessment2()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA2");
    }

    public void StartPatientassessment3and4()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA3N4");
    }

    public void StartPatientassessment5()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA5");
    }

    public void StartPatientassessment6()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA6");
    }

    public void StartPatientassessment7()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA7");
    }

    public void StartPatientassessment8_1()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA8.1");
    }

    public void StartPatientassessment9_2()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA9.2");
    }

    public void StartPatientassessment10_3()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("PA10.3");
    }


    //{FOR PATIENT ASSESSMENT --END--}



    //{FOR RAPID EXTRICATION --START--}
    public void StartRapid2()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid2");
    }

    public void StartRapid3()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid3");
    }

    public void StartRapid4()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid4");
    }

    public void StartRapid5()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid5");
    }

    public void StartRapid5_6()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid5_6");
    }

    public void StartRapid7()
    {
        // Call the LoadScene method of SceneTransitionManager with the scene name
        transitionManager.LoadScene("Rapid7");
    }
    //{FOR RAPID EXTRICATION --END--}
}
