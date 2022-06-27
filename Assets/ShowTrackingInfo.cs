using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTrackingInfo : MonoBehaviour
{
    [SerializeField] private Camera m_targetCamera;
    private Text m_txtInfo;

    void Start()
    {
        m_txtInfo = GetComponent<Text>();
    }
    void Update()
    {
        m_txtInfo.text = $"{m_targetCamera.transform.position.ToString()}\n" +
            $"{m_targetCamera.transform.rotation.ToString()}";
    }
}
