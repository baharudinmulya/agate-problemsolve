using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Prob1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Prob2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Prob3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Prob4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Prob5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Prob6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void Prob7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void Prob8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void Prob9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void KeMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu1()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu2()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu3()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu4()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu5()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu6()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu7()
    {
        SceneManager.LoadScene(0);
    }
    public void KeMainMenu8()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadMainMenu()
    {

        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}