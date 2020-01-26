using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

   public void Menu()
    {
        SceneManager.LoadScene("Game");
        PlayerScript.Walls = 1;
        BushScript.bushHealth = 3;
        MilkScript.timeLeft = 25.0f;
        MilkScript.milkNum = 0;
        SprinklerScript.waterLevel = 3;
    }

   public void End()
    {
        SceneManager.LoadScene("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
