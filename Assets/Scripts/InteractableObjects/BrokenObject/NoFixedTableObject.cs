using AosSdk.Core.PlayerModule.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFixedTableObject : BaseObject
{
    [SerializeField] private Animator _animator;
   
    private bool _upPosition;
    
    public override void OnClicked(InteractHand interactHand)
    {
        if (_upPosition)
        {
            _animator.SetTrigger("Down");
            _upPosition = false;

        }
        else 
        {
            _animator.SetTrigger("Up");
            _upPosition = true;

        }


      

    }
 
}
