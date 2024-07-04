using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enforce : MonoBehaviour
{
    public Button enforce_price;        // 강화 버튼 눌렀을때

    // Start is called before the first frame update
    void Start()
    {
        enforce_price.onClick.AddListener(onClick_Enfore_price);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick_Enfore_price()
    {
        Debug.Log("enforce button click");
    }
}
