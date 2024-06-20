using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUIHandler : MonoBehaviour
{

    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartButtonClick() {
        DataManager.Instance.m_name = inputField.text;
        SceneManager.LoadScene(1);
    }
}
