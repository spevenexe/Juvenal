using UnityEngine;
using Juvenal;
using System;

// [CreateAssetMenu(menuName = "Effect/DrawEffect")]
[Serializable]
public class DrawEffect : CardEffect
{
    [SerializeField] private int _numCards;

    public DrawEffect(Parameters parameters) : base(parameters)
    {
    }

    public override void ApplyEffect()
    {
        Debug.Log($"I draw {_numCards} cards.");
    }
}