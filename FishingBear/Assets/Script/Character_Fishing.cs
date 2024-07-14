using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character_Fishing : MonoBehaviour
{
    public Animator animator;
    public GameObject fishing_ui;   // 잡았을 때 뜨는 것
    public data_manager Data_manager;

    //int money_fish = 0;         // 향후 DB에서 플레이어 저장된 돈 값 불러오게 할것
    float time;         // 시간 

    float ani_time_idle = 1.0f;
    public float ani_time_fishing = 1.5f;

    bool isani = false;
    bool isidle = false;
    bool isfishing = false;

    
    // Start is called before the first frame update
    void Start()
    {
        load_data();
        
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

    void load_data()
    {

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
            Data_manager.money = Data_manager.money + Data_manager.earned_at_once;
            fishing_ui.SetActive(true);                                     // 화면에 띄워주는 ui 켜주기
            ui_fishing_it f = fishing_ui.GetComponent<ui_fishing_it>();     // 화면에 띄워주는 ui 불러오기
            f.fising_text.text = "1";                     // 화면에 띄워주는 ui text 수정 // 나중에 한번에 얼마가 벌리는지로 수정 해줄 것

            isidle = true;
        }
        StartCoroutine(ani2());
        yield return null;
    }

}
