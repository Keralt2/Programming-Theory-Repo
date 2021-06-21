using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public int heals;
    public Slider slider;
    public Text text;
    public GameObject target;
    public Camera GameCamera;
    public int damage;
    private Enemies enemies;
    private int maxHeals;
    public Text selectedEnemy;
    public Text PlayerParam;
    public Text gameOverText;
    public Button AttackButton;
    


    void Start()
    {
        maxHeals = 100;
        heals = maxHeals;
        damage = 15;
        slider.maxValue = maxHeals;
        PlayerParametersUI();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
    }
    public void HandleSelection()
    {
        var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.TryGetComponent<Enemies>(out enemies))
        {
            var unit = hit.collider.gameObject;
            /*var transform = hit.collider.GetComponent<Transform>();
            transform.position = new Vector3(0f, 2f, 3f);*/
            target = unit;
            AttackButton.interactable = true;
            selectedEnemy.text = target.name + "\n Damage " + target.GetComponent<Enemies>().damageDeal 
                + "\n HP " +target.GetComponent<Enemies>().heals +"/" + target.GetComponent<Enemies>().maxHeals;
        }
    }

    public void HPChange(int damage)
    {
        heals -= damage;
        slider.value = maxHeals-heals;
        text.text = heals.ToString() + "/" + maxHeals;
        PlayerParametersUI();
        if (heals<=0)
        {
            heals = 0;
            gameOverText.gameObject.SetActive(true); 
            gameObject.SetActive(false);
                  
        }
    }

    public void DealDamage()
    {
        if (target != null)
        {
            target.GetComponent<Enemies>().ReceiveDamage(damage);
            if (target != null)
            {
                selectedEnemy.text = target.name + "\n Damage " + target.GetComponent<Enemies>().damageDeal
                + "\n HP " + target.GetComponent<Enemies>().heals + "/" + target.GetComponent<Enemies>().maxHeals;
            }
            else
            {
                AttackButton.interactable = false;
                selectedEnemy.text = "Select enemy";
            }
        }
    }

    private void PlayerParametersUI()
    {
        PlayerParam.text = MenuUI.Instance.Name + "\n Damage " + damage + "\n HP " + heals.ToString() + "/" + maxHeals;
    }
}
