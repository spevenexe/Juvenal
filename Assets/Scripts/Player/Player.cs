using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerMovement _playerMovement; 
    [SerializeField] private CardDisplay _cardInHand;

    [SerializeField] private InputActionReference _movementInput, _talk, _jump;
    // [SerializeField] private InputActionReference _playCard; 

    void OnEnable()
    {
        _talk.action.performed+=Talk;
        _jump.action.performed+=Jump;
        // _playCard.action.performed+=_cardInHand.PlayCard;
    }

    void OnDisable()
    {
        _talk.action.performed-=Talk;
        _jump.action.performed-=Jump;
        // _playCard.action.performed-=_cardInHand.PlayCard;
    }

    void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        // PlayerInput playerInput = GetComponent<PlayerInput>();
        // ReadOnlyArray<InputAction> inputActions = playerInput.currentActionMap.actions; 
        // _movementInput = inputActions.IndexOf()
    }

    void Update()
    {
        _playerMovement.HorizontalDir = _movementInput.action.ReadValue<float>(); // take care of joystick behavior. this value is not rounded
    }

    private void Talk(InputAction.CallbackContext context)
    {
        string garble = "";
        int messageLength = Random.Range(1,20);
        for (int i = 0; i < messageLength; i++)
        {
            char nextCharacter = (char)Random.Range(char.MinValue,char.MaxValue);
            garble += nextCharacter;
        }

        Debug.Log(garble);
    }

    void Jump(InputAction.CallbackContext context)
    {
        _playerMovement.Jump(context);
    }
}
