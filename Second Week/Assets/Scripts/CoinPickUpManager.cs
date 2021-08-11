using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickUpManager : MonoBehaviour
{
    private int coinsPicked = 0;
    public Text currentCoins;
    [SerializeField]int coinsInLevel = 25;

    GameManager gameManager;
    AudioSource _audioSource;



    #region  Singleton
    public static CoinPickUpManager instance;
    
    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogWarning("More than one CoinPickUpManager!");
            return;
        }
        instance = this;
    }
    #endregion
    private void Start()
    {
        gameManager = GetComponent<GameManager>();
        _audioSource = GetComponent<AudioSource>();
    }


    public void PickUp()
    {
        _audioSource.Play();
        coinsPicked++;
        currentCoins.text = coinsPicked.ToString();
        if (coinsPicked==coinsInLevel)
        {
            gameManager.Win();
        }
        
    }

}
