using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Slider>().interactable = false;//Bar�� ��ġ�� �ȵǵ��� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
