using UnityEngine;
using Juvenal;
using System.Collections.Generic;
using UnityEditor;
using System;
using Unity.VisualScripting;
using System.Linq;

[CreateAssetMenu(menuName = "Card/BaseCard")]
[Serializable]
public class Card : ScriptableObject
{
    [field:SerializeField] public string Description {get; private set;}
    [field:SerializeField] public string CardName {get; private set;}
    [field:SerializeField] public Sprite Art {get; private set;}

    // [SerializeReference] private CardEffect _cardEffect = new CardEffect();
    [SerializeReference, SubclassSelector]
    public CardEffect Effect = new CardEffect();
    // [field:SerializeField] public CardEffectType Type {get; private set;}
    // [field:SerializeField] public String Params {get; private set;}
}

[CreateAssetMenu(menuName = "Card/Rock")]
[Serializable]
public class Rock : Card
{

}