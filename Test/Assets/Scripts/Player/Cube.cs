using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Player
{
    [SerializeField] private Image _healthBar;

    [SerializeField] private float _startTimer = 2, _damage = 2; // Вы можете задать промежуток временя и урон для NPC
    private float _health, _timer;
    private void Start() { _timer = _startTimer; }

    private void Update()
    {
        if (NPC._isAttack)
        {
            if (_timer <= 0)
            {
                if (_health > 0) _health = GetDamage(_health, _damage);
                else _health = 10; // Почему я тут указал жесткие значения прочитайте в скрипте Player

                _timer = _startTimer;
            }

            else _timer -= Time.deltaTime;
        }

        HealthBar(_healthBar, _health);
    }
}
