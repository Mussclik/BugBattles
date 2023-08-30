using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SLider : MonoBehaviour
{
    [SerializeField] float myfloat;
    [SerializeField] GameObject mygameObject;
    [SerializeField] UnityEngine.UI.Slider slider;
    private void Start()
    {
        slider = mygameObject.GetComponent<UnityEngine.UI.Slider>();
    }
    public void OnSliderUpdate()
    {
        myfloat = slider.value;
        Debug.Log("slider value " + slider.value);
    }
}
