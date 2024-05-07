using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    Monster,
    Spell,
    Trap
}

public enum AttributeType
{
    Dark,
    Light,
    Fire,
    Water,
    Earth,
    Wind,
    Divine,
    Spell,
    Trap
}

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/YuGiOh/Card")]
public class Card : ScriptableObject
{
    [SerializeField] private string cardName;
    [SerializeField, TextArea(0, 150)] private string cardDescription;
    [SerializeField] private CardType cardType;
    [SerializeField] private AttributeType cardAttribute;
}
