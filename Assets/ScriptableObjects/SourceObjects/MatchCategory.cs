using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MatchCategory", menuName = "ScriptableObjects/MatchCategory")]
public class MatchCategory : ScriptableObject
{
    public string label;
    public List<Match> matches;
}
