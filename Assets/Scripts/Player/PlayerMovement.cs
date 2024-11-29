using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [HideInInspector] public float HorizontalDir;
    
    [SerializeField] private float _jumpImpulse;

    private BoxCollider2D _box;
    private Rigidbody2D _rb;


    [SerializeField] private LayerMask _terrainLayer;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _box = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(HorizontalDir * _speed,_rb.linearVelocity.y);
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if(grounded())
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x,_jumpImpulse);
    }

    private RaycastHit2D grounded()
    {
        Vector2 origin = _box.bounds.center;
        origin.y -= _box.bounds.extents.y;
        return Physics2D.Raycast(origin,Vector2.down,0.1f,_terrainLayer);
    }
}
