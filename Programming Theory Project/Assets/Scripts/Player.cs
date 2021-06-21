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
    private int maxHeals;
    public Text selectedEnemy;
    


    void Start()
    {
        heals = 100;
        maxHeals = 100;
        damage = 10;
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
        if (Physics.Raycast(ray, out hit))
        {
            var unit = hit.collider.gameObject;
            /*var transform = hit.collider.GetComponent<Transform>();
            transform.position = new Vector3(0f, 2f, 3f);*/
            target = unit;
            selectedEnemy.text = target.name + "\n Damage " + target.GetComponent<Enemies>().damage 
                + "\n HP " +target.GetComponent<Enemies>().heals +"/" + target.GetComponent<Enemies>().maxHeals;
        }
    }

    public void HPChange(int damage)
    {
        heals -= damage;
        slider.value = maxHeals-heals;
        text.text = heals.ToString() + "/" + maxHeals;
    }
}
