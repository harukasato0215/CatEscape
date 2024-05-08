using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        //this.hpGauge = GameObject.Find("hpGauge");

    }
    public void DecreaseHp()
    {
        this.hpGauge.fillAmount -= 0.1f;
    }


}
