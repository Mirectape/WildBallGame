using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour
{
    Animator currentAnimation;
    int randomAnimationNumber;
    int numberOfAnimations;

    void Start()
    {
        SetDefaultValues();
    }

    private void ChangeAnimation()
    {
        currentAnimation.SetInteger("AnimationNumber", RandomizeAnimation());
    }

    private int RandomizeAnimation() => randomAnimationNumber = Random.Range(0, numberOfAnimations);

    private void SetDefaultValues()
    {
        currentAnimation = GetComponent<Animator>();
        numberOfAnimations = 3;
    }
}
