using System;
using System.Collections.Generic;
using UnityEngine;
// NOTES
// take care not to enter inheritance/component hell <<<<<<<<<<<<<<<< !
// card effects can be composed of smaller card effects. 
    // For instance, a basic "Deal Damage" and a "Heal" can be combined in anothe card effect, then that card effect can be used to define another... etc. 
// should card effects occur sequentially, or in parallel? sequential is easier to deterministically resolve, but parallelism may open up more options
    // e.g. dashing and dealing damage simultaneously (though this can probably be done better by creating a "Damaging Dash" subclass of "Dash" and maybe "Attack" too)
    // somtimes i might want to effects to have second gaps in between them. Like if i want a "Life Steal" effect to only trigger AFTER a hit confirmation, though again, this is probably better done as a subclass to "Attack"
    // perhaps create a hybrid system with await keywords that wait for a subset of effects to complete before moving on

namespace Juvenal {

public enum EffectType{
    Attack,
    Draw
}

[Serializable]
public struct Effect{
    public EffectType effectType;
    public Parameters parameters;
}

[Serializable]
public struct Parameters{
    public int numCards;
    public float baseDamage;
}

public class CardEffect
{
    protected Parameters _parameters; 

    public CardEffect(Parameters parameters){
        this._parameters = parameters;
    }

    public virtual void ApplyEffect(){
        throw new NotImplementedException();
    }
}

}

