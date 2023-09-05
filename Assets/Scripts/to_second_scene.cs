using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class to_second_scene : MonoBehaviour
{    
    public void ChangeScene()
    {
        SceneManager.LoadScene("second_scene");
    }
}
