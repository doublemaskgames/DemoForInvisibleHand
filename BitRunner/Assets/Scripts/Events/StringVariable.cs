using UnityEngine;

[CreateAssetMenu(fileName = "StringVariable", menuName = "ScriptableVariables/StringVariable", order = 0)]
public class StringVariable : ScriptableGameObject {
    public string speaker;
    [TextArea(3,10)]
    public string line;
}