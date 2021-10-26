using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NPC : NonePlayerCharacter
{
    [SerializeField] private float _speed = 2;
    [SerializeField] private Transform _pointToAttack, _pointToSwap;

    public static bool isSecond_NonePlayerCharacter = true, _isSwap = false, _isAttack = false;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_isSwap == true)
            if (isSecond_NonePlayerCharacter == false) NonePlayerCharacter_Move(_pointToAttack, _speed);
            else NonePlayerCharacter_Move(_pointToSwap, _speed);

        if (_isAttack == false) NonePlayerCharacter_Animation(_animator, "Idle");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _isAttack = true;
            NonePlayerCharacter_Animation(_animator, "Attack");
        }
    }
}
