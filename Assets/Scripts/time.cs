using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text txt_timeFloored;
    public float elapsedTime;
    public GameObject txt_ganaste;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();
        if (currentTime > 15)
        {
            txt_ganaste.SetActive(true);
        }
    }
}
