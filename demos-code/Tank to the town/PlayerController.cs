using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] float force = 1000f;
    [SerializeField] float horizontalInput;
    private int xBoundary = 17;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
            horizontalInput = Input.GetAxis("Horizontal");
            playerRb.AddRelativeForce(Vector3.left * horizontalInput * Time.deltaTime * force, ForceMode.Impulse);
            BoundaryRestrict();
    }
    //ABSTRACTION
    void BoundaryRestrict()
    {
        Vector3 rePlaceRight = new Vector3(xBoundary, 0, 0);
        Vector3 rePlaceLeft = new Vector3(-xBoundary, 0, 0);
        if (transform.position.x > xBoundary)
        {
            transform.position = rePlaceRight;
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
        }
        if(transform.position.x < -xBoundary)
        {
            transform.position = rePlaceLeft;
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vehicle"))
        { 
            Destroy(other.gameObject);
        }
    }
}
