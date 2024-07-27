using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Scanner : XRGrabInteractable
{
    [Header("Scanner Data")]
    public Animator animator;
    public LineRenderer lineRenderer;

    protected override void Awake()
    {
        base.Awake();
        lineRenderer.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    { 
        base.OnSelectEntered(args);
        animator.SetBool("Opened", true); 
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        animator.SetBool("Opened", false); 
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        lineRenderer.gameObject.SetActive(true);
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
        lineRenderer.gameObject.SetActive(false);
    }
}
