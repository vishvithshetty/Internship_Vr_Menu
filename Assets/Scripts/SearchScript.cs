using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchScript : MonoBehaviour
{
    public GameObject Container;

    public GameObject[] Element;

    public GameObject SearchBar;

    public int totalElements;

    // Start is called before the first frame update
    void Start()
    {

        totalElements = Container.transform.childCount;

        Element = new GameObject[totalElements];

        for(int i = 0; i<totalElements; i++){
            Element[i] = Container.transform.GetChild(i).gameObject;
        }

    }

    public void Search(){
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;

        int searchTxtlength = SearchText.Length;

        int searchedElements = 0;

        foreach(GameObject ele in Element){

            searchedElements += 1;

            if(ele.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.Length >= searchTxtlength)
            {
                if(SearchText.ToLower() == ele.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.Substring(0,searchTxtlength).ToLower())
                {
                    ele.SetActive(true);
                }
                else
                {
                    ele.SetActive(false);
                }
            }
        }
    }
}