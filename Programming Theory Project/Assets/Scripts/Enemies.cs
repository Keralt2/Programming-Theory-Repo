using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    public GameObject player;
    public Text text;
    public Slider slider;
    public int heals, damageDeal;
    static public int enemiesCount = 3;
    public Text gameOverText;
    private int maxHealsBack = 100;
    public int maxHeals  // ENCAPSULATION
    {
        get { return maxHealsBack; }
        set
        {
            if (value <0)
            {
                Debug.LogError("You can't set a negative HP");
            }
            else
            {
                maxHealsBack = value;
            }
        }
    }

    private void Start()
    {
        Parameters(); // ABSTRACTION

    }
    public virtual void Parameters()
    {
        heals = 50;
        maxHeals = 50;
        damageDeal = 5;
        text.text = heals.ToString() + "/" + maxHeals;
        slider.maxValue = maxHeals;
    }
    public void DealDamage()
    {
        player.GetComponent<Player>().HPChange(damageDeal);
    }

    public void ReceiveDamage(int damage)
    {
        heals -= damage;
        slider.value = maxHeals - heals;
        text.text = heals.ToString() + "/" + maxHeals;
        if (heals <=0)
        {
            heals = 0;
            damageDeal = 0;
            player.GetComponent<Player>().target = null;
            enemiesCount -= 1;
            Debug.Log(enemiesCount);
            if (enemiesCount <=0)
            {
                gameOverText.gameObject.SetActive(true);
                gameOverText.text = "You Win!!!";
            }
            gameObject.SetActive(false);

        }

    }
}
