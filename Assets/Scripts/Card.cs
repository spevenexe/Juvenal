using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/BaseCard")]
public class Card : ScriptableObject
{
    [field:SerializeField] public string Description {get; private set;}
    [field:SerializeField] public string CardName {get; private set;}
    [field:SerializeField] public Sprite Art {get; private set;}
    [field:SerializeField] public CardEffect Effect {get; private set;}

    // public void ExecuteEffect(){
    //     Debug.Log($"My name is {CardName}");
    // }
}
