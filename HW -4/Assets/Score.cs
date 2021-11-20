using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public CoinPicker cp;
    public Text counter;

    private void Update()
    {
        counter.text = CoinPicker.coin.ToString();
    }
}
