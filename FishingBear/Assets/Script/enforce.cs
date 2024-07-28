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
    int[] enforce_price_m = new int [] { 0,5,10,20,30,40,50,60,70,80,90};   // 강화 비용

    public TMP_Text enforce_level_text; // 강화 레벨에 대한 text
    public TMP_Text enforce_text;   // 강화에 대한 설명 텍스트
    public TMP_Text enforce_m_text; // 강화 비용 텍스트
    public TMP_Text enforce_m_text2; // 강화 비용 텍스트 2

    public Button enforce_price;        // 강화 버튼 눌렀을때


    // Start is called before the first frame update
    void Start()
    {
        enforce_level = 1;
        enforce_price.onClick.AddListener(onClick_Enfore_price);                // 버튼 클릭 이벤트 연결
        enforce_m_text.text = enforce_price_m[enforce_level].ToString();                       // button on 텍스트
        enforce_m_text2.text = enforce_price_m[enforce_level].ToString();                      // button off 텍스트
        enforce_level_text.text = "Lv." + enforce_level.ToString();                     // 레벨 텍스트 수정
        enforce_text.text = enforce_level.ToString();                           // 설명란 레벨 텍스트 수정
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("enforce_level" + enforce_level + "enforce_price_m" + enforce_price_m.Length);
        //Debug.Log("enforce_price_m[0]" + enforce_price_m[0]);
        //Debug.Log("enforce_price_m[1]" + enforce_price_m[1]);
        if (Data_manger.money >= enforce_price_m[enforce_level])
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
        Data_manger.money = Data_manger.money - enforce_price_m[enforce_level];
        Data_manger.earned_at_once = Data_manger.earned_at_once + 1;
        enforce_level++;
        enforce_level_text.text = "Lv." + enforce_level.ToString();
        enforce_text.text = enforce_level.ToString();
        enforce_m_text.text = enforce_price_m[enforce_level].ToString();                       // button on 텍스트
        enforce_m_text2.text = enforce_price_m[enforce_level].ToString();                      // button off 텍스트
    }
}
