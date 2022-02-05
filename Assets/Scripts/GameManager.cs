using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;
    public static GameManager instance;

    // background variables
    public Sprite[] backgrounds;
    private int currentBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;

    private void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 3;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "Gold: " + gold.ToString();
    }
    
    public void TakeGold(int amount)
    {
        gold -= amount;
        if (gold < 0)
        {
            gold = 0;
        }
        goldText.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;
        if (enemiesUntilBackgroundChange == 0)
        {
            enemiesUntilBackgroundChange = 3;
            currentBackground++;

            if (currentBackground == backgrounds.Length)
            {
                currentBackground = 0;
            }
            backgroundImage.sprite = backgrounds[currentBackground];
        }
    }
}
