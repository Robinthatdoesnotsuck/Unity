using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    public GameObject dogPrefab;
    [SerializeField]
    private float cooldown = 1.0f;
    [SerializeField] 
    private float canDo = -1.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canDo)
        {
            canDo = Time.time + cooldown;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
