using System.Collections.Generic;
using UnityEngine;
using Juvenal;

// [CreateAssetMenu(menuName = "Effect/StackedEffects")]
public class StackedEffect : CardEffect
{
    [SerializeField] private List<CardEffect> _effects;

    public StackedEffect(List<CardEffect> effects)
    {
        _effects = effects;
    }

    public override void ApplyEffect()
    {
        foreach(CardEffect e in _effects){
            e.ApplyEffect();
        }
    }
    
}