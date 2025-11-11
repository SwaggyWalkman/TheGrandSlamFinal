using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{	
	private GameManager gameManager;
	private CoinManager cm;
	public float startYPosition = 0f;
	
	// Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        cm = GameObject.Find("CoinManager").GetComponent<CoinManager>();
		Destroy(this.gameObject, 3.5f);
		Vector3 newPosition = transform.position;
		newPosition.y = startYPosition;
		transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {

	}
	
	void OnTriggerEnter2D(Collider2D collectCoin)
	{
		if(collectCoin.CompareTag("Player"))
		{
			cm.coinCount++;
			Destroy(this.gameObject);
		}
	}
}
