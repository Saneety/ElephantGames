using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redhood_run : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private void OnMouseDown()
    {
        animator.Play("redhood_run");
    }
}
