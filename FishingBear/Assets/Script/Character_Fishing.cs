using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character_Fishing : MonoBehaviour
{
    public Animator animator;
    public TMP_Text money_text;     // 향후 업데이트 되는 text 따로 관리 할거면 분리 할것
    int money_fish = 0;         // 향후 DB에서 플레이어 저장된 돈 값 불러오게 할것
    float time;         // 시간 

    float ani_time_idle = 1.0f;
    float ani_time_fishing = 1.5f;

    bool isani = false;
    bool isidle = false;
    bool isfishing = false;

    
    // Start is called before the first frame update
    void Start()
    {
        money_text.text = "0";
        isidle = true;
        //StartCoroutine(idle());
    }

    // Update is called once per frame
    void Update()
    {
        
        money_timer();
        
    }

    private void FixedUpdate()
    {
        StartCoroutine(ani());
    }

    void money_timer()      // 돈 버는 함수
    {
        Debug.Log("money_timer");
        time += Time.deltaTime;
        if(time >= 3.0)
        {
            isfishing = true;
            animator.Play("fishing");
            Debug.Log("money_timer up!");
            time = 0;
            money_fish++;
            money_text.text = money_fish.ToString();
        }

    }

    IEnumerator ani()
    {
        if(isani == false)
        {
            isani = true;
            Debug.Log("코루틴 도는 중");
            if (isidle == true)
                animator.Play("idle");

            if (isfishing == true)
            {
                Debug.Log("고기 잡는 중");
                animator.Play("fishing");
                yield return new WaitForSeconds(ani_time_fishing);
                isidle = true;
                isfishing = false;
            }
        }

        isani = false;
        yield return null;
    }

    IEnumerator timer_ani(float f)
    {

        yield return new WaitForSeconds(f);

        yield return null;
    }
}
