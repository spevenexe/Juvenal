using UnityEngine;
using Juvenal;
using System;

[Serializable]
public class AttackEffect : CardEffect
{
    [SerializeField] private float _baseDamage;

    public override void ApplyEffect(Caster caster)
    {
        Debug.Log($"Me do {_baseDamage} damage.");
    }
}

[Serializable]
public class ProjectileAttackEffect : AttackEffect
{
    [SerializeField] private Sprite _projectileSprite;

    public override void ApplyEffect(Caster caster)
    {
        base.ApplyEffect(caster);
        Debug.Log("Throw the thing");
    }
}