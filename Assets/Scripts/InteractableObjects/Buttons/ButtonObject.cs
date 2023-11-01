using AosSdk.Core.PlayerModule.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : BaseObject
{
    
    [SerializeField] private Animator[] _waterAnim;
    


    public override void OnClicked(InteractHand interactHand)
    {

        foreach (var anim in _waterAnim) 
        {                    
                anim.SetTrigger("Idle");                     
        }

    }
}
