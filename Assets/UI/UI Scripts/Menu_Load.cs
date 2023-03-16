using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Load : MonoBehaviour
{
    public void LoadScene(string Menu)
    {
        SceneManager.LoadScene("Menu");
    }

}
