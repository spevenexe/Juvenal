using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CardDisplay))]
public class CardDisplayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CardDisplay cardDisplay = (CardDisplay) target;
        if (GUILayout.Button("Test Apply Effect"))
        {
            cardDisplay.TestApplyEffect();
        }
    }
}