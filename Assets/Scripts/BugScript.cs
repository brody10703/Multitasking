using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugScript : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

        //bugs move when spawned
    void Update()
    {
        Vector3 pos = transform.position;

            pos.x -= speed * Time.deltaTime;

        transform.position = pos;
    }
}
