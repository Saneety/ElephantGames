using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight_animations_controller : MonoBehaviour
{
    [SerializeField]
    private Animator animatorKnightHeal;
    [SerializeField]
    private Animator animatorKnightPray;


    private void OnMouseDown()
    {
        animatorKnightHeal.Play("knight_heal");
        animatorKnightPray.Play("knight_pray");
    }
}