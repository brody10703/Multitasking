using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerScript : MonoBehaviour
{
    public static int waterLevel = 3;
    public Sprite full, most, less, empty;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        InvokeRepeating("WaterLoss", 8, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if (waterLevel <= 3)
        {
            sr.sprite = full;
        }
        if (waterLevel <= 2)
        {
            sr.sprite = most;
        }
        if (waterLevel <= 1)
        {
            sr.sprite = less;
        }
        if (waterLevel <= 0)
        {
            sr.sprite = empty;
        }
    }


    void WaterLoss()
    {
        waterLevel--;
    }

}
