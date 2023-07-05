using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _damage;

    public void Deal()
    {
        _player.GetDamage(_damage);
    }
}
