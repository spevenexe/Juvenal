using UnityEngine;

[CreateAssetMenu(menuName = "Effect/DrawEffect")]
public class DrawEffect : CardEffect
{
    [SerializeField] private int _numCards;

    public override void ApplyEffect()
    {
        Debug.Log($"I draw {_numCards} cards.");
    }
}