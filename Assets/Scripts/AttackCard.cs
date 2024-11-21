using UnityEngine;
using Juvenal;

[CreateAssetMenu(menuName = "Card/AttackCard")]
public class AttackCard : Card
{
    [SerializeField] private AttackEffect _effect;
    public override void ApplyEffect() => _effect.ApplyEffect();
}