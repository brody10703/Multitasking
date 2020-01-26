using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int wallHealth = 6;
    SpriteRenderer sr;
    public Sprite full, cracked, broken;
    public AudioSource zap, crack;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (wallHealth <= 6)
        {
            sr.sprite = full;
            crack.Play();
        }
        if (wallHealth <= 4)
        {
            sr.sprite = cracked;
            crack.Play();
        }
        if (wallHealth <= 2)
        {
            sr.sprite = broken;
            crack.Play();

        }
        if (wallHealth <= 0)
        {
            Destroy(gameObject);
            PlayerScript.Walls++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bug")
        {
            wallHealth--;
            Destroy(collision.gameObject);
            zap.Play();
            //print(wallHealth);
        }
    }
}
