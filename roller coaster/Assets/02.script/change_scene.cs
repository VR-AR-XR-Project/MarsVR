using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("First_scene");

        //if(other.gameObject.layer == 3)
        //{
        //    SceneManager.LoadScene("Second_scene");
        //}
    }
}
