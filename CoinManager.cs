using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount = 0;
	public TextMeshProUGUI coinText;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
	
    public void AddScore(int coinCount)
    {
        coinText.text = "Coins: " + coinCount;
    }
}
