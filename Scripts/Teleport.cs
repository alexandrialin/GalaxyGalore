using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject welcome;
    void OnTriggerEnter(Collider other)
    {
        
        if (gameObject.CompareTag("rocket"))
        {
            if (other.gameObject.CompareTag("robot"))
            {
                SceneManager.LoadScene(2);
            }
        }
        else
        {
            Instantiate(welcome, new Vector3(0, 0, 0), Quaternion.identity);
            StartCoroutine(Hesitate());
        }
        }
    IEnumerator Hesitate()
    {
        yield return new WaitForSeconds(1);
        if (gameObject.CompareTag("earth"))
        {
            SceneManager.LoadScene(3);
        }
        if (gameObject.CompareTag("mars"))
        {
            SceneManager.LoadScene(4);
        }
        if (gameObject.CompareTag("mercury"))
        {
            SceneManager.LoadScene(5);
        }
        if (gameObject.CompareTag("venus"))
        {
            SceneManager.LoadScene(6);
        }
        if (gameObject.CompareTag("jupiter"))
        {
            SceneManager.LoadScene(7);
        }
        if (gameObject.CompareTag("moon"))
        {
            SceneManager.LoadScene(8);
        }
        if (gameObject.CompareTag("saturn"))
        {
            SceneManager.LoadScene(9);
        }
        if (gameObject.CompareTag("uranus"))
        {
            SceneManager.LoadScene(10);
        }
        if (gameObject.CompareTag("neptune"))
        {
            SceneManager.LoadScene(11);
        }
       
    }
}

