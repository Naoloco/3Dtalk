using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody playRigidbody;
    float moveX, moveZ;
    public float speed;

	// Use this for initialization
	void Start () {
        playRigidbody = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
        Movementcontroller();

    }

    void Move()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        playRigidbody.AddForce(new Vector3(speed * moveX, 0, speed * moveZ));
    }

    void Movementcontroller()
    {
        if(!talkthing.isTalking)
        {
            playRigidbody.constraints = RigidbodyConstraints.FreezePositionY;
            Move();
        }
        else
        {
            //RigidbodyConstraints abccc = GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            playRigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
    }
}
