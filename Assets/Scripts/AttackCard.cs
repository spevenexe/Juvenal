using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Card",menuName = "Card/AttackCard")]
public class AttackCard : Card
{
    [SerializeField] private float _baseDamage;

    new public void ExecuteEffect()
    {
        Debug.Log($"I did {_baseDamage} damage.");
        // throw new System.NotImplementedException();
    }
}