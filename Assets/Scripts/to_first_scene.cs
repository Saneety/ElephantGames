using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class to_first_scene : MonoBehaviour
{    
    public void ChangeScene()
    {
        SceneManager.LoadScene("first_scene");
    }
}
