using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    private Animator animator;
    private bool isOpen;
    private int shouldOpen = Animator.StringToHash(nameof(shouldOpen));

    /// <summary>
    /// Using a constructor here to intialize displayText in the editor
    /// </summary>
    public Door()
    {
        displayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }
    public override void InteractWith()
    {
        if (!isOpen)
        {
            base.InteractWith();
            animator.SetBool(shouldOpen, true);
            displayText = string.Empty;
            isOpen = true;
        }
    }
}
