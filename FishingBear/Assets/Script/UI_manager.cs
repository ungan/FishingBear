using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{
    public Button manu1_button;
    public GameObject manu1;

    public Button manu2_button;
    public GameObject manu2;

    public Button manu3_button;
    public GameObject manu3;

    public Button manu4_button;
    public GameObject manu4;

    public Button manu1_button_exit;
    public Button manu2_button_exit;
    public Button manu3_button_exit;
    public Button manu4_button_exit;



    // Start is called before the first frame update
    void Start()
    {
        manu1_button.onClick.AddListener(onClick_manu1_button);
        manu2_button.onClick.AddListener(onClick_manu2_button);
        manu3_button.onClick.AddListener(onClick_manu3_button);
        manu4_button.onClick.AddListener(onClick_manu4_button);

        manu1_button_exit.onClick.AddListener(onClick_manu1_button_exit);
        manu2_button_exit.onClick.AddListener(onClick_manu2_button_exit);
        manu3_button_exit.onClick.AddListener(onClick_manu3_button_exit);
        manu4_button_exit.onClick.AddListener(onClick_manu4_button_exit);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void onClick_manu1_button()         // 버튼 눌렸을때 창 켜줄 것 듯
    {
        manu1.SetActive(true);
    }

    void onClick_manu2_button()
    {
        manu2.SetActive(true);
    }


    void onClick_manu3_button()
    {
        manu3.SetActive(true);
    }


    void onClick_manu4_button()
    {
        manu4.SetActive(true);
    }


    void onClick_manu1_button_exit()
    {
        manu1.SetActive(false);
    }

    void onClick_manu2_button_exit()
    {
        manu2.SetActive(false);
    }
    void onClick_manu3_button_exit()
    {
        manu3.SetActive(false);
    }
    void onClick_manu4_button_exit()
    {
        manu4.SetActive(false);
    }

}
