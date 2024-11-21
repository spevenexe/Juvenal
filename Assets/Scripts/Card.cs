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

    List<CardEffect> _cardEffects;
    List<Effect> Effects;
    void OnEnable(){
        _cardEffects = new List<CardEffect>();

        foreach(Effect e in Effects){
            EffectType type = e.effectType;
            Parameters parameters = e.parameters;

            CardEffect cardEffect = new AttackEffect(parameters); // this is just for defaults case, ignore this
            switch(type){
                case EffectType.Attack:
                    cardEffect = new AttackEffect(parameters);
                    break;
                case EffectType.Draw:
                    cardEffect = new DrawEffect(parameters);
                    break;
            }
            _cardEffects.Add(cardEffect);
        }
    }
}
