using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character_Fishing : MonoBehaviour
{
    public Animator animator;
    public TMP_Text money_text;     // ���� ������Ʈ �Ǵ� text ���� ���� �ҰŸ� �и� �Ұ�
    int money_fish = 0;         // ���� DB���� �÷��̾� ����� �� �� �ҷ����� �Ұ�
    float time;         // �ð� 

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

    void money_timer()      // �� ���� �Լ�
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
            Debug.Log("�ڷ�ƾ ���� ��");
            if (isidle == true)
                animator.Play("idle");

            if (isfishing == true)
            {
                Debug.Log("��� ��� ��");
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
