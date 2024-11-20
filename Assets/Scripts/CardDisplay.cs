using System;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card _card;

    void Start(){
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = _card.Art;
    }

    void Update()
    {
        if(Input.GetButtonDown("Interact")){
            _card.Effect.ApplyEffect();
        }
    }
}
