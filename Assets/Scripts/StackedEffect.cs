using System.Collections.Generic;
using UnityEngine;
using Juvenal;

// [CreateAssetMenu(menuName = "Effect/StackedEffects")]
public class StackedEffect : CardEffect
{
    // [field:SerializeField] public List<CardEffect> Effects {get; private set;}

    // public override void ApplyEffect()
    // {
    //     foreach(CardEffect e in Effects){
    //         e.ApplyEffect();
    //     }
    // }
    public StackedEffect(Parameters parameters) : base(parameters)
    {
    }
}