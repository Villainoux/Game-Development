using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameLoader : MonoBehaviour
{
    public void GoNextScene() 
    {
        SceneManager.LoadScene("Tutorial Level");
    }
}
