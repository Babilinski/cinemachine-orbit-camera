using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationStateController : MonoBehaviour
{
    private Animator targetAnimator;

    // Start is called before the first frame update
    void Start()
    {
        targetAnimator = GetComponent<Animator>();
    }

    
    public void SetAnimationState(string stateName)
    {
        targetAnimator.CrossFade(stateName,0);
    }
}
