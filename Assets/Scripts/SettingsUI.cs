using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [Header ("UI References :")]
    [SerializeField] private GameObject uiCanvas;
    [SerializeField] private Button uiCloseButton;
    // Start is called before the first frame update
    private void Awake(){
        uiCloseButton.onClick.AddListener(Close);
        Close();
    }

    public void Open(){
        uiCanvas.SetActive(true);
    }

    public void Close(){
        uiCanvas.SetActive(false);
    }

    private void OnDestroy(){
        uiCloseButton.onClick.RemoveListener(Close);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
