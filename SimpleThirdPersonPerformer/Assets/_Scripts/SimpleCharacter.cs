using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacter : MonoBehaviour {

	// Use this for initialization
    public Vector3 pos;

    void Start()
    {
        pos.x = -1768.7f;
        pos.y = 2487.9f;
        pos.z = 221.4f;

    }
	
	// Update is called once per frame
	void Update () {
        float playerInpX = Input.GetAxis("Horizontal");
        float playerInpZ = Input.GetAxis("Vertical");

        pos.x += playerInpX;
        pos.y += playerInpZ;

        transform.position = pos;

        print("X " + playerInpX + " Z " + playerInpZ);

       
	}
}
