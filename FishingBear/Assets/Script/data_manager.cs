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

    // Start is called before the first frame update
    void Start()
    {
        earned_at_once = 1;
        money_text.text = "0";
        earned_at_fishing_trap = 1;
        fishing_trap_cooltime = 10;
        fishing_trap_count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        money_text.text = money.ToString();
    }
}
