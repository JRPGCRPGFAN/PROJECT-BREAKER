using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Encapsulates the battle hub variables into one class.
public class BattleHUB : MonoBehaviour
{
    public Text characterName;
    public Text characterHP;
    public Slider characterHpSlider;

    // Fill out the battle HUB with the character's data.
    public void SetupHUB(Character character)
    {
        characterName.text = character.name;
        characterHP.text = character.getCurrentVitality + "HP/" 
            + character.getVitality + "HP";
        SetCharacterHpSlider(character.getVitality);
    }

    public void SetCharacterHpSlider(int newHP) 
    {
        characterHpSlider.value = newHP;
    }
}
