using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public GameObject Menu;
    private GameManager _gameManager;
    public PlayerMov Movement; 
    private int Cost = 0;
    public Sprite Sprite;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Upgrade()
    {
        if (_gameManager.coinCount >= Cost)
        {
            _gameManager.SubtractCoins(Cost);
            Cost += 2;
            Movement.UpgradeTrain(2, Sprite);
        }
    }

    public void MenuOnOff(bool isOn)
    {
        Menu.SetActive(isOn);
    }
}
