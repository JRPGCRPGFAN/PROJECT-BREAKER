using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Encapsulates the battle hub variables into one class.
public class BattleHUB : MonoBehaviour
{
    public TMPro.TextMeshProUGUI characterName;
    public TMPro.TextMeshProUGUI characterHP;
    public Slider characterHpSlider;

    // Fill out the battle HUB with the character's data.
    public void SetupHUB(Character character)
    {
        characterName.text = character.characterName;
        characterHP.text = character.CurrentVitality + "/" 
            + character.Vitality + "HP";
        SetCharacterHpSlider(character.CurrentVitality, character.Vitality);
    }

    public void SetCharacterHpSlider(int currentHp, int maxHp) 
    {
        characterHpSlider.maxValue = maxHp;
        characterHpSlider.value = currentHp;
        
    }
}
