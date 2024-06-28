using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour
{
   public void Mytask()
    {
        SceneManager.LoadScene("my task");
    }

    public void alltask()
    {
        SceneManager.LoadScene("all task");
    }
    public void agronom()
    {
        SceneManager.LoadScene("agronom");
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void mexanizator()
    {
        SceneManager.LoadScene("mexanizator");
    }

     public void ZP()
    {
        SceneManager.LoadScene("ZP");
    }
     public void polomka()
    {
        SceneManager.LoadScene("polomka");
    }
    public void mextask()
    {
        SceneManager.LoadScene("mex task");

    }
    public void chouse_task()
    {
        SceneManager.LoadScene("chouse task");
    }














}
