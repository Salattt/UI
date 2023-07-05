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

    public event Action<float> HealthChanched;

    private void OnEnable()
    {
        HealthChanched += _hpBar.OnHealthChanged;
    }

    private void OnDisable()
    {
        HealthChanched -= _hpBar.OnHealthChanged;
    }

    public void GetDamage(float damage)
    {
        _health -= damage;

        if(_health < _minHealth)
            _health = _minHealth;

        if (_health > _maxHealth)
            _health = _maxHealth;

        HealthChanched.Invoke(_health/ _maxHealth);
    }
}
