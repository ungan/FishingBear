using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class data_manager : MonoBehaviour
{
    public int money;
    public int earned_at_once;      // 한번에 버는 돈
    public int earned_at_fishing_trap = 1; // 통발로 버는 돈
    public float fishing_trap_cooltime = 10;   // 통발에 물고기가 잡히는 시간
    public int fishing_trap_count = 1;      // 통발에 물고기가 저장되는 회수
    public TMP_Text money_text;     // 향후 업데이트 되는 text 따로 관리 할거면 분리 할것

    // 향후 따로 정리할 data table
    public int enforce_price_fishprice = 0;
    public int enforce_price_level = 1;
    int[] enforce_price_fishprice_arr = new int[] { 0, 5, 10, 20, 30, 40, 50, 60, 70, 80, 90 };   // 강화 비용

    // Start is called before the first frame update
    void Start()
    {
        earned_at_once = 1;
        money_text.text = "0";
        earned_at_fishing_trap = 1;
        fishing_trap_cooltime = 10;
        fishing_trap_count = 1;
        enforce_price_fishprice = enforce_price_fishprice_arr[enforce_price_level];
    }

    // Update is called once per frame
    void Update()
    {
        money_text.text = money.ToString();
        update_data();
    }

    void update_data()
    {
        enforce_price_fishprice = enforce_price_fishprice_arr[enforce_price_level];
    }

    public int get_enforce_price_fishprice()
    {
        return enforce_price_fishprice = enforce_price_fishprice_arr[enforce_price_level];
    }

}
