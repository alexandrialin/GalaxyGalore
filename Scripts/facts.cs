using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class facts : MonoBehaviour
{

    public GameObject fact;    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("astronaut"))
        {
            if (other.gameObject.CompareTag("robot"))
            {
                Instantiate(fact, new Vector3(0, 0, 0), Quaternion.identity);

            }
        }
        else {
            Instantiate(fact, new Vector3(0, 0, 0), Quaternion.identity);
        }
     
    }
}
