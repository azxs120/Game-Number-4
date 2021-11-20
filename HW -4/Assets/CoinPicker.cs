using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinPicker : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
    public int getCoins()
    {
        return coin;
    }
}
