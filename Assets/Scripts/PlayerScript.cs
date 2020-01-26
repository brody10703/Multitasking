using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 20f;
    public GameObject wall;
    public static int Walls = 1;
    public static bool watered, milked;
    public AudioSource wellNoise, sprinklerNoise, cowNoise, milkNoise;


    //handles player movement and application quitting
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //print(watered);

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        transform.position = pos;

        if (Input.GetKey("e") && Walls > 0)
        {
            Instantiate(wall, new Vector3(pos.x + 1, pos.y, pos.z), Quaternion.identity);
            Walls--;
        }
    }

    //handles collisions with various objects. Each different tagged object causes a different gameplay mechanic to occur
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Well")
        {
            if (watered == false)
            {
                watered = true;
                wellNoise.Play();

            }
        }

        if (collision.gameObject.tag == "Sprinkler")
        {
            if (watered == true)
            {
                watered = false;
                SprinklerScript.waterLevel++;
                sprinklerNoise.Play();
            }
        }

        if (collision.gameObject.tag == "Cows")
        {
            if (milked == false)
            {
                milked = true;
                cowNoise.Play();
            }
        }

        if (collision.gameObject.tag == "Milk")
        {
            if (milked == true)
            {
                MilkScript.milkNum++;
                milkNoise.Play();
                milked = false;
            }
        }
    }
}
