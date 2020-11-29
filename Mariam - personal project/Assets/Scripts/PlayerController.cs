using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 200.0f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("Player had collided with obstacle.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cookie")) ;
        {
            Debug.Log("Player collected cookie");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Bonus")) ;
        {
            Debug.Log("Player collected bonus cookie");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("PowerUp")) ;
        {
            Debug.Log("Player gained a power up");
            Destroy(other.gameObject);
        }
    }
}
