using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [Header ("UI References:")]
    [SerializeField] private Button uiSettingsButton;
    [Header("Settings UI")]
    [SerializeField] private SettingsUI settingsUI;
    // Start is called before the first frame update
    void Start()
    {
        uiSettingsButton.onClick.AddListener(() => settingsUI.Open());
    }

    private void OnDestroy(){
        uiSettingsButton.onClick.RemoveAllListeners();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
