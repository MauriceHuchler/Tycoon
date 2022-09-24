using UnityEngine;

[
    CreateAssetMenu(
        fileName = "GeneSO",
        menuName = "GeneTycoon/GeneSO",
        order = 0)
]
public class GeneSO : ScriptableObject
{
    public string geneName;

    public float number;
}
