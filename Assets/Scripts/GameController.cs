using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Bugs;

    // Start is called before the first frame update

        //spawns the bugs in intervals
    void Start()
    {
        InvokeRepeating("Spawn1", 6, 6);
        InvokeRepeating("Spawn2", 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //spawns bug
    void Spawn1()
    {
        Instantiate(Bugs, new Vector3(25, -11, 0), Quaternion.identity);
    }
    //also spawns bug
    void Spawn2()
    {
        Instantiate(Bugs, new Vector3(25, -11, 0), Quaternion.identity);
    }
}
