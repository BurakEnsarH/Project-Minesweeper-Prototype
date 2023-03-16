using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyScene : MonoBehaviour
{
    public void LoadScene(string Easy)
    {
        SceneManager.LoadScene("Easy");
    }
    
}
