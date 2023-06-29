using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HPBar _hpBar;

    private float _health = 50;
    private float _maxHealth = 100;
    private float _minHealth = 0;
    private float _healthQuantity = 10;
    public void GetDamage()
    {
        _health -= _healthQuantity;

        if(_health < _minHealth)
            _health = _minHealth;

        _hpBar.ChangeValue(_health / _maxHealth);
    }

    public void GetHeal()
    {
        _health += _healthQuantity;

        if (_health > _maxHealth)
            _health = _maxHealth;

        _hpBar.ChangeValue(_health/ _maxHealth);
    }
}
