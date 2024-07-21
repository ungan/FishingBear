using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ui_fishing_it : MonoBehaviour
{
    public RectTransform ui_fishing;
    public Image fishing_image;
    public TMP_Text fising_text;
    public data_manager Data_manager;

    Vector2 first_position;
    Color fishing_image_color;
    Color fishing_text_color;


    

    // Start is called before the first frame update
    void Start()
    {
        fishing_image_color = fishing_image.color;
        fishing_text_color = fising_text.color;
        first_position = ui_fishing.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {

        fishing_text_color.a = fishing_text_color.a - Time.deltaTime * 0.5f;
        fishing_image_color.a = fishing_image_color.a - Time.deltaTime * 0.5f;

        fishing_image.color = fishing_image_color;
        fising_text.color = fishing_text_color;

        ui_fishing.anchoredPosition = new Vector2(ui_fishing.anchoredPosition.x, ui_fishing.anchoredPosition.y + Time.deltaTime * 30.0f);

        fising_text.text = Data_manager.earned_at_once.ToString();

        if (fishing_text_color.a <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    
    private void OnDisable()
    {
        ui_fishing.anchoredPosition = first_position;
        fishing_text_color.a = 1f;
        fishing_image_color.a = 1f;

        fishing_image.color = fishing_image_color;
        fising_text.color = fishing_text_color;

    }
}


