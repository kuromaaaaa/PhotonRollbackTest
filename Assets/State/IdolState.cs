using UnityEngine;

public class IdolState : IState
{
    int IState.AnimationHash { get => Animator.StringToHash("Idol"); }

    bool IState.IsChange { get => true; }

    public void StateStart()
    {
    }

    public void StateUpdate()
    {
    }

    public void StateEnd()
    {
    }
}
