using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card _card;
    [SerializeField] private Image _cardArt;
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;

    void Start(){
        if (_card == null){
            Debug.LogWarning("No Card object. Using defaults...");
        }else{
            _cardArt.sprite = _card.CardArt;
            _title.text = _card.CardName;
            _description.text = _card.Description;

        }
    }

    public void Play()
    {
        _card.Effect.ApplyEffect(null);
    }

    public void PlayCard(InputAction.CallbackContext context)
    {
        _card.Effect.ApplyEffect(null);
    }

    public void TestApplyEffect()
    {
        _card.Effect.ApplyEffect(null);
    }
}