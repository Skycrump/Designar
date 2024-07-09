using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueBtn : MonoBehaviour
{

    public void GoToMainPageUI()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void BackToMainPageUI()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void LoadSingleSofaScene()
    {
        SceneManager.LoadScene("Single sofa");
    }

}
