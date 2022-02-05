using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Image healthBarFill;
    public int currentHP;
    public int maxGP;
    public int goldToGive;
    public Animation anim;

    public void Damage()
    {
        currentHP--;
        healthBarFill.fillAmount = (float)currentHP / (float)maxGP;
        anim.Stop();
        anim.Play();

        if (currentHP <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
