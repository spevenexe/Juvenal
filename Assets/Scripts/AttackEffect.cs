using UnityEngine;

[CreateAssetMenu(menuName = "Effect/AttackEffect")]
public class AttackEffect : CardEffect
{
    [SerializeField] private float _baseDamage;

    public override void ApplyEffect()
    {
        Debug.Log($"I did {_baseDamage} damage.");
    }
}