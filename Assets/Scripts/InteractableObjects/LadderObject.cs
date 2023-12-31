using AosSdk.Core.PlayerModule.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderObject : BaseObject
{
  
    [SerializeField] private Collider _polkaCollider;
    private Animator _animator;   
    private bool _open = false;
    private void Start()
    {
        _animator = GetComponent<Animator>();
     
    }

    public override void OnClicked(InteractHand interactHand)
    {
        if (!_open)
        {
            _animator.SetTrigger("Open");
            _open= true;
            _polkaCollider.enabled= false;
        }
        else 
        {
            _animator.SetTrigger("Close");
            _open = false;
            _polkaCollider.enabled = true;
        }
       

    }
   
}
