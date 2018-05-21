using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private Button startbuttn;
    void Start()
    {
        Button buton = startbuttn.GetComponent<Button>();
        buton.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene("work");
    }
}


