using UnityEngine;
using Juvenal;
using System;

// [CreateAssetMenu(menuName = "Effect/DrawEffect")]
[Serializable]
public class DrawEffect : CardEffect
{
    [SerializeField] private int _numCards;

    public DrawEffect(int numCards)
    {
        _numCards = numCards;
    }

    public override void ApplyEffect()
    {
        Debug.Log($"I draw {_numCards} cards.");
    }
}