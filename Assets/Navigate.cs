using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public float panSpeed = 20f;
    public int speed = 2;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(","))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("."))
        {
            pos.y -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
