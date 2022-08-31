using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenController : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CategoriesMenu()
    {
        SceneManager.LoadScene("CategoriesMenu");
    }

    public void FruitsCat()
    {
        SceneManager.LoadScene("FruitScene");
    }
     
    public void FlowerCat()
    {
        SceneManager.LoadScene("FlowerScene");
    }
     
    public void AnimalsCat()
    {
        SceneManager.LoadScene("AnimalScene");
    }
     
    public void SportsCat()
    {
        SceneManager.LoadScene("SportsScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
