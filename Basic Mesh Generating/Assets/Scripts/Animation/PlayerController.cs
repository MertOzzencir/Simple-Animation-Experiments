using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    [SerializeField] private float ForcePower;
    [SerializeField] private float GroundForcePower;

    [SerializeField] private float JumpPower;

    public Rigidbody _rb;
    public bool _canInteract;
    public bool IsDead;
    public LayerMask LayerMask;
    public bool _canBounce;
    public bool _canBounceBack;
    public bool _gameOver;

    float _xInput;
    float _yInput;
    Vector3 _input;
    bool _canJump;
    float _timerForBounceToGround =1f;

    private void Start()
    {
        instance = this;
    }
    void Update()
    {
        _xInput = Input.GetAxisRaw("Horizontal");
        _yInput = Input.GetAxisRaw("Vertical");
        _input = new Vector3(_xInput, 0,_yInput);

        if (Input.GetKeyDown(KeyCode.Space) && _canInteract)
        {
            _canJump = true;
        }
        _timerForBounceToGround += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F) && _timerForBounceToGround > 1f)
        {
            _canBounce = true;
            _canBounceBack = true;
            _timerForBounceToGround = 0;
        }

    }

    private void FixedUpdate()
    {
        if(!IsDead && !_gameOver)
            _rb.AddForce(_input * Time.fixedDeltaTime * ForcePower,ForceMode.VelocityChange);

        if (_canJump && !_gameOver)
        {
            _rb.AddForce(Vector3.up * Time.fixedDeltaTime * JumpPower, ForceMode.VelocityChange);
            _canJump = false;
            _canInteract = false;
        }
        if (_canBounce)
        {
            _canBounce = false;
            _rb.velocity = Vector3.zero; 
            _rb.AddForce(Vector3.down * Time.deltaTime * GroundForcePower, ForceMode.Impulse);

        }
    }
}
