using AosSdk.Core.PlayerModule.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindsObject : BaseObject
{
   
    
    private Animator _animator;
    private bool _open = true;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public override void OnClicked(InteractHand interactHand)
    {
        if (_open)
        {
            _animator.SetTrigger("Idle");
            _open= false;
        }
        else
        {
            _animator.SetTrigger("Reverse");
            _open = true;
        }

        

    }

}
