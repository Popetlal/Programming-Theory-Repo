using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cake : Interactable
{
    private PlayerHealth health;
    private Data data;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Player").GetComponent<PlayerHealth>();
        data = GameObject.Find("GameManager").GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        data.message = $"Your health was {health.health}/{health.maxHealth}";
        SceneManager.LoadScene(3);
    }
}
