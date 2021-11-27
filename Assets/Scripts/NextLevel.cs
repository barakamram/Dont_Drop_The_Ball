using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] string scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
            SceneManager.LoadScene(scene);
        // Input can either be a serial number or a name; here we use name. 
    }
}       
