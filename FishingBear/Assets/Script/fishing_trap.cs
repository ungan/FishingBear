using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fishing_trap : MonoBehaviour, IPointerClickHandler
{
    public data_manager dt_manager;
    public float cooltime = 0;
    public int maxcount = 0;

    public GameObject fish_image;       //물고기가 있다는 표시 띄워주기

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
            if (maxcount < dt_manager.fishing_trap_count)       // 물고기 카운트 셈
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
        if (maxcount >= 1)     // 물고기가 1마리 이상 잡혔을 경우 돈을 줄 것
        {
            Debug.Log("test1 in");
            dt_manager.money = dt_manager.money + dt_manager.earned_at_fishing_trap * maxcount;        // 원래 가진돈 + 추가로 번돈 (물고기 한마리 값 * 잡힌 물고기 개수)
            fish_image.SetActive(false);
            maxcount = 0;
        }
    }
}
