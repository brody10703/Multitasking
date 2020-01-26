using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BushScript : MonoBehaviour
{
    public static int bushHealth = 3;
    SpriteRenderer sr;
    public Sprite life, lower, lowest, decayed;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        InvokeRepeating("BushDying", 3, 7); //causes the bush to die, losing life and changing sprite
    }

    // Update is called once per frame
    void Update()
    {
        if (bushHealth <= 3)
        {
            sr.sprite = life;
        }
        if (bushHealth <= 2)
        {
            sr.sprite = lower;
        }
        if (bushHealth <= 1)
        {
            sr.sprite = lowest;
        }
        if (bushHealth <= 0)
        {
            sr.sprite = decayed;
            SceneManager.LoadScene("End");
        }

        //print(bushHealth);
    }

    void BushDying()
    {

        if (SprinklerScript.waterLevel <= 0) //called during the start to cause the bush to take damage
        {
            bushHealth--;
        }
    }
}
