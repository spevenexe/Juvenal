using UnityEngine;
using Juvenal;
using System;

// [CreateAssetMenu(menuName = "Effect/AttackEffect")]
[Serializable]
public class AttackEffect : CardEffect
{
    [SerializeField] private float _baseDamage;

    public AttackEffect(float baseDamage)
    {
        _baseDamage = baseDamage;
    }

    public override void ApplyEffect(){/*do damage*/}
}