using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class Buttons : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (gameObject.CompareTag("about"))
        {
            SceneManager.LoadScene(1);
        }
        if (gameObject.CompareTag("back"))
        {
            SceneManager.LoadScene(0);
        }
        if (gameObject.CompareTag("play"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
