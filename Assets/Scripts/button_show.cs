using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button_show : MonoBehaviour
{
    [SerializeField]
    private GameObject button;
    private void OnMouseDown()
    {
        button.SetActive(true);
    }
}
