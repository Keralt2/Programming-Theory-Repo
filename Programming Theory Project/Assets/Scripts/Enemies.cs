using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    public GameObject player;
    public Text text;
    public Slider slider;
    public int heals,maxHeals,damage;

    private void Start()
    {
        Parameters();

    }
    public virtual void Parameters()
    {
        heals = 100;
        maxHeals = 100;
        damage = 10;
        text.text = heals.ToString() + "/" + maxHeals;
    }
    public void DealDamage()
    {
        player.GetComponent<Player>().HPChange(damage);
    }

    public void ReceiveDamage(int damage)
    {
        heals -= damage;
        slider.value = maxHeals - heals;
        text.text = heals.ToString() + "/" + maxHeals;

    }
}
