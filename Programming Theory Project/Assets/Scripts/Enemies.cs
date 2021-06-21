using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    public GameObject player;
    public Text text;
    public Slider slider;
    public int heals,maxHeals,damageDeal;

    private void Start()
    {
        Parameters();

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
            Debug.Log("target = null");
            gameObject.SetActive(false);

        }

    }
}
