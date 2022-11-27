using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XrGrabInteractableAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;
    
    protected override void OnSelectEntered(SelectEnterEventArgs args) // here override function is used to to make the function in child class be called when the same function is called in parent class
    {
        if(args.interactableObject.transform.CompareTag("left hand"))
        {
            attachTransform = leftAttachTransform;  
        }
        else if (args.interactableObject.transform.CompareTag("right hand"))
        {
            attachTransform = rightAttachTransform;
        }

        base.OnSelectEntered(args);

    }
}
