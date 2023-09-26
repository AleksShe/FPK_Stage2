using AosSdk.Core.PlayerModule.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KranObject : BaseObject
{
   
    [SerializeField] private Animator _animator;
    private bool _open = true;
    public override void OnClicked(InteractHand interactHand)
    {
       if(_open)
        {
            _animator.SetTrigger("Idle");
            _open= false;
        }
        else
        {
            _animator.SetTrigger("Broken");
            _open= true;
        }
    }
}
