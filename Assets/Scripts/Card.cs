using UnityEngine;
using Juvenal;
using System.Collections.Generic;
using UnityEditor;

[CreateAssetMenu(menuName = "Card/BaseCard")]
public class Card : ScriptableObject
{
    [field:SerializeField] public string Description {get; private set;}
    [field:SerializeField] public string CardName {get; private set;}
    [field:SerializeField] public Sprite Art {get; private set;}

    public virtual void ApplyEffect(){
        Debug.Log($"My name is {CardName}");
    }

    private CardEffect _cardEffect;
    [field:SerializeField] public EffectAndParameters EffectAndParams {get; private set;}
    void OnEnable(){
        _cardEffect = CardEffect.GetCardEffect(EffectAndParams);
    }
}
