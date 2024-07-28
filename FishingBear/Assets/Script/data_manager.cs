using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class data_manager : MonoBehaviour
{
    public int money;
    public int earned_at_once;      // �ѹ��� ���� ��
    public int earned_at_fishing_trap = 1; // ��߷� ���� ��
    public float fishing_trap_cooltime = 10;   // ��߿� ����Ⱑ ������ �ð�
    public int fishing_trap_count = 1;      // ��߿� ����Ⱑ ����Ǵ� ȸ��
    public TMP_Text money_text;     // ���� ������Ʈ �Ǵ� text ���� ���� �ҰŸ� �и� �Ұ�

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
