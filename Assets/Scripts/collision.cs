using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject txt_perdiste;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Auto")
        {
            Destroy(gameObject);
            txt_perdiste.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
