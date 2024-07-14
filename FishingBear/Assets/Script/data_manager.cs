using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class data_manager : MonoBehaviour
{
    public int money;
    public int earned_at_once;      // 한번에 버는 돈
    public TMP_Text money_text;     // 향후 업데이트 되는 text 따로 관리 할거면 분리 할것

    // Start is called before the first frame update
    void Start()
    {
        earned_at_once = 1;
        money_text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        money_text.text = money.ToString();
    }
}
