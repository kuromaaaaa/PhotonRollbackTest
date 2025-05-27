using UnityEngine;

public interface IState
{
    int AnimationHash { get;}
    bool IsChange { get; }
    void StateStart();
    void StateUpdate();
    void StateEnd();
}