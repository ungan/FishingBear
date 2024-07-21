using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    public GameObject obj_boat;
    public Vector3 up_position;
    public Vector3 down_position;

    bool isup = true;

    // Start is called before the first frame update
    void Start()
    {
        Transform obj_position = obj_boat.GetComponent<Transform>();
        up_position = new Vector3(obj_position.position.x, obj_position.position.y + 0.5f, obj_position.position.z);
        down_position = new Vector3(obj_position.position.x, obj_position.position.y - 0.5f, obj_position.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if(isup == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Time.deltaTime, gameObject.transform.position.z);

            if(gameObject.transform.position.y - up_position.y <= 0.01)
            {
                isup = false;
            }
        }
        else if(isup == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - Time.deltaTime, gameObject.transform.position.z);

            if (gameObject.transform.position.y - down_position.y <= 0.01)
            {
                isup = true;
            }
        }

    }

    float  onsub(float f1, float f2)
    {
        float tmp;
        tmp = f1 - f2;
        if (tmp < 0)
        {
            tmp = tmp * -1.0f;
        }

        return tmp;
    }
}
