using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerMeter : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 5;
    public float debugHelth = 0;
    public Slider hungerBar;
    public Vector3 offset = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        curHealth--;
        hungerBar.value = curHealth;
        if (curHealth <=0)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        curHealth = maxHealth;
        hungerBar.fillRect.gameObject.SetActive(true);
        hungerBar.value = curHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
