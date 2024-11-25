using UnityEngine;
using Juvenal;
using System;

// [CreateAssetMenu(menuName = "Effect/AttackEffect")]
[Serializable]
public class AttackEffect : CardEffect
{
    [SerializeField] private float _baseDamage;

    public override void ApplyEffect()
    {
        Debug.Log($"Me do {_baseDamage} damage.");
    }
}