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
    public float ani_time_fishing = 1.5f;

    bool isani = false;
    bool isidle = false;
    bool isfishing = false;

    
    // Start is called before the first frame update
    void Start()
    {
        money_text.text = "0";
        isidle = true;
        //StartCoroutine(idle());
        StartCoroutine(ani2());
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(ani2());
        //money_timer();

    }

    private void FixedUpdate()
    {
        if (isani == false)
        {
            isani = true;
            //StartCoroutine(ani2());
            isani = false;
        }
    }

    IEnumerator ani2()
    {

        if (isidle == true)
        {
            Debug.Log("idle");
            animator.SetBool("isfishing", false);
            yield return new WaitForSeconds(3f);
            isidle = false;
        }
        animator.Play("idle");

        if (isidle == false)
        {
            Debug.Log("fishing");
            animator.SetBool("isfishing", true);
            animator.Play("fishing");
            yield return new WaitForSeconds(ani_time_fishing);
            Debug.Log("fishing yield return");
            money_fish++;
            money_text.text = money_fish.ToString();
            isidle = true;
        }
        StartCoroutine(ani2());
        yield return null;
    }

}
