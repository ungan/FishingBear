using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fishing_trap : MonoBehaviour, IPointerClickHandler
{
    public data_manager dt_manager;
    public float cooltime = 0;
    public int maxcount = 0;

    public GameObject fish_image;       //����Ⱑ �ִٴ� ǥ�� ����ֱ�

    // Start is called before the first frame update
    void Start()
    {
        fish_image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cooltime = cooltime + Time.deltaTime;
        //Debug.Log("cool time : " + cooltime);
        Debug.Log("dt_manager.fishing_trap_cooltime :" + dt_manager.fishing_trap_cooltime);

        if (cooltime >= dt_manager.fishing_trap_cooltime)
        {
            cooltime = 0;
            if (maxcount < dt_manager.fishing_trap_count)       // ����� ī��Ʈ ��
            {
                Debug.Log("aaa");
                fish_image.SetActive(true);
                maxcount++;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("test1");
        if (maxcount >= 1)     // ����Ⱑ 1���� �̻� ������ ��� ���� �� ��
        {
            Debug.Log("test1 in");
            dt_manager.money = dt_manager.money + dt_manager.earned_at_fishing_trap * maxcount;        // ���� ������ + �߰��� ���� (����� �Ѹ��� �� * ���� ����� ����)
            fish_image.SetActive(false);
            maxcount = 0;
        }
    }
}
