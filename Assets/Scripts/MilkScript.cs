using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MilkScript : MonoBehaviour
{
    public static float timeLeft = 25.0f;
    public Text milkText;
    public static int milkNum = 0;
    public Sprite mempty,m1, m2, mfull;
    SpriteRenderer sr;


  void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        milkText.text = ("Milk Shipment: " + timeLeft + "");
        if (timeLeft < 0)
        {
            Time.timeScale = 0;
        }
        if (milkNum >= 0)
        {
            sr.sprite = mempty;
        }
        if (milkNum >= 1)
        {
            sr.sprite = m1;
        }
        if (milkNum >= 2)
        {
            sr.sprite = m2;
        }

        if (milkNum >= 3)
        {
            sr.sprite = mfull;
        }

        if (timeLeft <= 0 && milkNum < 3)
        {
            SceneManager.LoadScene("End");
        }

        if (timeLeft <= 0 && milkNum >= 3)
        {
            timeLeft = 25.0f;
            Time.timeScale = 1;
            milkNum = 0;
        }
    }
}
