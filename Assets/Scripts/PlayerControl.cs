using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rigibody;
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    [SerializeField] private KeyCode Forward;
    [SerializeField] private KeyCode Back;
    [SerializeField] private KeyCode Right;
    [SerializeField] private KeyCode Left;
    [SerializeField] private bool isGrounded;
    private void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(Forward)) GetComponent<Rigidbody>().velocity += new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(Back)) GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(Right)) GetComponent<Rigidbody>().velocity += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(Left)) GetComponent<Rigidbody>().velocity -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rigibody.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isGrounded = true;
    }
    


}
