using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    [SerializeField] private GameObject door;
    private bool doorOpen;
    private bool openOnce;

    private PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen && !openOnce)
        {
            openOnce = true;
            StartCoroutine(ifDoorOpen());
        }

    }

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }

    public IEnumerator ifDoorOpen()
    {

            playerHealth.TakeDamage(7.5f);
            yield return new WaitForSeconds(1);
            StartCoroutine(ifDoorOpen());
    }
}
