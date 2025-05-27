using UnityEngine;

public class FrontWalkState : IState
{
    
    int IState.AnimationHash { get => Animator.StringToHash("FrontWalk"); }
    bool IState.IsChange { get => true; }
    
    Rigidbody _rb;
    float _walkSpeed;
    
    public FrontWalkState(Rigidbody rb, float walkSpeed)
    {
        _rb = rb;
        _walkSpeed = walkSpeed;
    }

    public void StateStart()
    {
    }

    public void StateUpdate()
    {
        _rb.position += Vector3.right * _walkSpeed;
    }

    public void StateEnd()
    {
    }
}
