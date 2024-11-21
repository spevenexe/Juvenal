using System;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card _card;

    void Start(){
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = _card.Art;
    }

    void Update()
    {
        if(Input.GetButtonDown("Interact")){
            _card.ApplyEffect();
        }
    }
}
