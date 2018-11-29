using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {
    public static UIHandler instance;

    public GameObject endPanel;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void ShowEndPanel()
    {
        endPanel.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
