using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2.0f;

    Vector3 getInput;

    private void Update()
    {
        getInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
    
        GetComponent<Rigidbody>().velocity = getInput * moveSpeed;

        Vector3 lookPos = new Vector3(transform.position.x + GetComponent<Rigidbody>().velocity.x, transform.position.y, transform.position.z + GetComponent<Rigidbody>().velocity.z);

        transform.LookAt(lookPos);
    }

}
