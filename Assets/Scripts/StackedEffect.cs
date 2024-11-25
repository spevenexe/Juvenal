using System.Collections.Generic;
using UnityEngine;
using Juvenal;
using System;

[Serializable]
public class StackedEffect : CardEffect
{
    [SerializeReference, SubclassSelector] private List<CardEffect> _effects = new List<CardEffect>();

    public override void ApplyEffect()
    {
        foreach(CardEffect e in _effects){
            e.ApplyEffect();
        }
    }
    
}