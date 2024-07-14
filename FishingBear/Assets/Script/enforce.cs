using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enforce : MonoBehaviour
{
    public data_manager Data_manger;

    public GameObject button_on;
    public GameObject button_off;

    public int enforce_level;   // 강화 레벨
    public int enforce_price_m;   // 강화 비용

    public TMP_Text enforce_level_text; // 강화 레벨에 대한 text
    public TMP_Text enforce_text;   // 강화에 대한 설명 텍스트
    public TMP_Text enforce_m_text; // 강화 비용 텍스트
    public TMP_Text enforce_m_text2; // 강화 비용 텍스트 2

    public Button enforce_price;        // 강화 버튼 눌렀을때


    // Start is called before the first frame update
    void Start()
    {
        enforce_price.onClick.AddListener(onClick_Enfore_price);
        enforce_m_text.text = enforce_price_m.ToString();
        enforce_m_text2.text = enforce_price_m.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Data_manger.money >= enforce_price_m)
        {
            button_on.SetActive(true);
            button_off.SetActive(false);
        }

        else
        {
            button_on.SetActive(false);
            button_off.SetActive(true);
        }

    }

    void onClick_Enfore_price()
    {
        Debug.Log("enforce button click");
        enforce_level++;
        enforce_level_text.text = enforce_level.ToString();
        enforce_text.text = enforce_level.ToString();
    }
}
