using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
