using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shield : MonoBehaviour
{
    public GameObject shieldd;
    public bool activeShield;

    public float coolDownShield = 0f;
    private float startCoolDownShield = 10f;

    //public Slider sliderShield;
    bool collide = false;

    

    void Start()
    {
        activeShield = false;
        shieldd.SetActive(false);
        
       // sliderShield.gameObject.SetActive(false);
        //la valeur du slide commencera a chaque parti a sa valeur max
       // sliderShield.value = sliderShield.maxValue;
    }

    void Update()
    {
        if (collide )//&& sliderShield.value == sliderShield.maxValue)
        {
            //sliderShield.gameObject.SetActive(true);
            if (!activeShield)
            {
                shieldd.SetActive(true);
                activeShield = true;

            }
            ShieldBar();
        }
        if (activeShield == true)
        {
            coolDownShield -= 1 * Time.deltaTime;

            if (coolDownShield <= 0)
            {
                coolDownShield = 0;
                shieldd.SetActive(false);
                activeShield = false;
               
            }
        }
        else
        {
            //sliderShield.value += Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "shield")
        {
            Debug.Log("toucher");
            
            //sliderShield.gameObject.SetActive(true);
            collide = true;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "shield")
        {
            
           // sliderShield.gameObject.SetActive(true);
            collide = false;
        }
    }

    private void ShieldBar()
    {
        //sliderShield.value -= sliderShield.maxValue;
        coolDownShield = startCoolDownShield;
    }

    public bool ActiveShield
    {
        get { return activeShield; }
        set { activeShield = value; }
    }
}
