using UnityEngine;
using Juvenal;
using System;

[Serializable]
public class DrawEffect : CardEffect
{
    [SerializeField] private int _numCards;

    public override void ApplyEffect(Caster caster)
    {
        Debug.Log($"I draw {_numCards} cards.");
    }
}