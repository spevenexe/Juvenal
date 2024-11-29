using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /// <summary>
    /// The amount to lift the card by.
    /// </summary>
    private const float _LIFT_AMOUNT = 100f;
    /// <summary>
    /// The speed at which to lift the card.
    /// </summary>
    private const float _LERP_AMOUNT = 0.01f;
    private Coroutine cardLerpCoroutine;

    [SerializeField] public string Keybind;
    [SerializeField] private TMP_Text _keybind_text;

    public RectTransform RectTransform {get; private set;}
    private CardDisplay _card;

    private Vector2 _originalPosition, _liftPosition;

    void Start()
    {
        RectTransform = GetComponent<RectTransform>();
        _card = GetComponent<CardDisplay>();
        _keybind_text.text = Keybind;
        _originalPosition = RectTransform.anchoredPosition;
        _liftPosition = _originalPosition + Vector2.up * _LIFT_AMOUNT;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(cardLerpCoroutine is not null)
            StopCoroutine(cardLerpCoroutine);
        cardLerpCoroutine = StartCoroutine(LerpCard(_liftPosition));

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(cardLerpCoroutine is not null)
            StopCoroutine(cardLerpCoroutine);
        cardLerpCoroutine = StartCoroutine(LerpCard(_originalPosition));
    }

    IEnumerator LerpCard(Vector2 targetPosition)
    {
        Vector2 currentPosition = RectTransform.anchoredPosition;
        // float x = currentPosition.x;
        // float y = currentPosition.y;
        while(Vector2.Distance(currentPosition,targetPosition) > 0.1f) // TODO: serialize the constant later
        {
            currentPosition.x = Mathf.Lerp(currentPosition.x,targetPosition.x,_LERP_AMOUNT); // small note, that this does not account for pythagorean
            currentPosition.y = Mathf.Lerp(currentPosition.y,targetPosition.y,_LERP_AMOUNT); // lerping in both x and y simultaneously will cause more lerping than expected. TODO: use trig to split lerp into a vector

            RectTransform.anchoredPosition = currentPosition;
            yield return null;
        }

        yield break;
    }

    void Update()
    {
        if (Input.GetKeyDown(Keybind))
        {
            _card.Play();
        }
    }
}
