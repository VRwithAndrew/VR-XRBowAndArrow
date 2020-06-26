using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Quiver : XRSocketInteractor
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnSelectExit(XRBaseInteractable interactable)
    {
        base.OnSelectExit(interactable);
    }

    private void CreateAndSelectArrow()
    {

    }

    private Arrow CreateArrow()
    {
        return null;
    }

    private void SelectArrow(Arrow arrow)
    {

    }

    private void SetAttachOffset()
    {

    }
}
