using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{
    public Text text;
    private Data data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("GameManager").GetComponent<Data>();
        text.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = data.message;
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
