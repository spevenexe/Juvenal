using UnityEngine;
using Juvenal;
using System;

[CreateAssetMenu(menuName = "Card/BaseCard")]
[Serializable]
public class Card : ScriptableObject
{
    [field:SerializeField] public string Description {get; private set;}
    [field:SerializeField] public string CardName {get; private set;}
    [field:SerializeField] public Sprite CardArt {get; private set;}

    [SerializeReference, SubclassSelector]
    public CardEffect Effect = new CardEffect();
}