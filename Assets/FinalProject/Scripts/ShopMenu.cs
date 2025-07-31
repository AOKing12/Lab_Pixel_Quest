using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject Menu;
    public PlayerStats playerStats;
    public PlayerMov Movement; 
    private int Cost = 0;
    public Sprite Sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Upgrade()
    {
        if (playerStats._coinCounter >= Cost)
        {
            playerStats._coinCounter -= Cost;
            Cost += 2;
            Movement.UpgradeTrain(2, Sprite);
        }
    }

    public void MenuOnOff(bool isOn)
    {
        Menu.SetActive(isOn);
    }
}
