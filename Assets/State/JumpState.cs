using UnityEngine;

public class JumpState : IState
{
    int IState.AnimationHash { get => Animator.StringToHash("Jump"); }
    bool IState.IsChange { get => _isChage; }
    bool _isChage = false;

    float _originPosY;
    float _jumpPower = 1f;
    float _gravity = 0.1f;
    float _currentUpPower = 0f;
    Rigidbody _rb;

    public JumpState(Rigidbody rb, float originPosY)
    {
        _rb = rb;
        _originPosY = originPosY;
    }

    public void StateStart()
    {
        _currentUpPower = _jumpPower;
        _isChage = false;
    }

    public void StateUpdate()
    {
        _rb.position += Vector3.up * _currentUpPower;
        _currentUpPower -= _gravity;
        if (_rb.position.y < _originPosY)
        {
            Vector3 pos = _rb.position;
            _rb.position = new Vector3(pos.x, _originPosY, pos.z);
            _isChage = true;
        }
    }

    public void StateEnd()
    {
    }
}
