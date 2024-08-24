using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : Interactable
{
    private PlayerHealth health;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        health.TakeDamage(5);
    }
}
