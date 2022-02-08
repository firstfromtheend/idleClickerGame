using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterChanger : MonoBehaviour
{
    [SerializeField] public int[] clickerToBuy = new int[] { 1, 5, 10, 25 };
    private int indexForClickerToBuy = 0;
    public TextMeshProUGUI counterText;

    private void Start()
    {
        counterText.text = "Auto-clicker to buy: " + clickerToBuy[indexForClickerToBuy].ToString();
        //indexForClickerToBuy++;
    }

    public void ChangeCounterOnButton()
    {
        indexForClickerToBuy++;
        if (indexForClickerToBuy == 4)
        {
            indexForClickerToBuy = 0;
        }
        counterText.text = "Auto-clicker to buy: " + clickerToBuy[indexForClickerToBuy].ToString();
    }

    public int GetCounterQuantity()
    {
        return clickerToBuy[indexForClickerToBuy];
    }
}
