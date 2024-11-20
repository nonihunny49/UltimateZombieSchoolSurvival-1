using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    private SceneController _sceneController;
    public void Easy()
    {
        _sceneController.LoadScene("Easy Game");
    }

    public void Medium()
    {
        _sceneController.LoadScene("Medium Game");
    }

    public void Hard()
    {
        _sceneController.LoadScene("Hard Game");
    }
}
