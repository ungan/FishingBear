using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character_Fishing : MonoBehaviour
{
    public Animator animator;
    public GameObject fishing_ui;   // ����� �� �ߴ� ��
    public data_manager Data_manager;

    //int money_fish = 0;         // ���� DB���� �÷��̾� ����� �� �� �ҷ����� �Ұ�
    float time;         // �ð� 

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
            fishing_ui.SetActive(true);                                     // ȭ�鿡 ����ִ� ui ���ֱ�
            ui_fishing_it f = fishing_ui.GetComponent<ui_fishing_it>();     // ȭ�鿡 ����ִ� ui �ҷ�����
            f.fising_text.text = "1";                     // ȭ�鿡 ����ִ� ui text ���� // ���߿� �ѹ��� �󸶰� ���������� ���� ���� ��

            isidle = true;
        }
        StartCoroutine(ani2());
        yield return null;
    }

}
