using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int heals;
    public Slider slider;
    public Text text;
    private int maxHeals;
    // Start is called before the first frame update
    void Start()
    {
        heals = 100;
        maxHeals = 100;
    }
    public void HPChange(int Damage)
    {
        heals -= Damage;
        slider.value = 100-heals;
        text.text = heals.ToString() + "/" + maxHeals;
    }

}
