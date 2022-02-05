using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClicksLastTime = new List<float>();
    public TextMeshProUGUI autoClickerCounter;

    public int autoClickerPrice;

    private void Update()
    {
        for (int i = 0; i < autoClicksLastTime.Count; i++)
        {
            if (Time.time - autoClicksLastTime[i] >= 1.0f)
            {
                autoClicksLastTime[i] = Time.time;
                EnemyManager.instance.currentEnemy.Damage();
            }
        }
    }

    public void OnByAutoClicker()
    {
        if (GameManager.instance.gold >= autoClickerPrice)
        {
            GameManager.instance.TakeGold(autoClickerPrice);
            autoClicksLastTime.Add(Time.time);

            autoClickerCounter.text = "X" + autoClicksLastTime.Count.ToString();
        }
    }
}
