using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[
    CreateAssetMenu(
        fileName = "DNAController",
        menuName = "GeneTycoon/DNAController",
        order = 0)
]
public class DNAController : ScriptableObject
{
    [Range(0, 100)]
    public float mutateRate;

    public List<GeneSO> genes = new List<GeneSO>();
}
