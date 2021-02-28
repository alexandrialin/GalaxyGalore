using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class okButton : MonoBehaviour
{
    
    public Button yourButton;
    public GameObject fact;

    // Start is called before the first frame update
    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        yourButton.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Destroy(fact);
    }
    }
