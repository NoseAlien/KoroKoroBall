using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;
    public Vector3 respawnPoint;
    public bool goaled;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        goaled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (goaled)
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(new Vector3(0, 0, 1) * power);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody.AddForce(new Vector3(0, 0, -1) * power);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(new Vector3(1, 0, 0) * power);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
            }

            if (Input.GetKey(KeyCode.Return) || transform.position.y <= -10)
            {
                Respawn();
            }
        }
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CheckPoint")
        {
            respawnPoint = other.transform.position;
        }
    }
}
