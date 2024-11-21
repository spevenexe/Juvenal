using UnityEngine;
using Juvenal;
using System;

// [CreateAssetMenu(menuName = "Effect/AttackEffect")]
[Serializable]
public class AttackEffect : CardEffect
{
    [SerializeField] private float _baseDamage;

    public AttackEffect(Parameters parameters) : base(parameters){}

    public override void ApplyEffect()  
    {
        _baseDamage = _parameters.baseDamage;
        /*do something with that*/
    }
}