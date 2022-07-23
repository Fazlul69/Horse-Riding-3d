using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OddButtonClick : MonoBehaviour
{
    public int number;
    
    public void ClickButton()
    {
        string st = GetComponent<Text>().text;
        number =  int.Parse(st);
        string obName = gameObject.name;
        Debug.Log(obName);
        transform.gameObject.GetComponent<Text>().text = "1";
        transform.gameObject.GetComponent<Text>().color = Color.red;   

        GameManager.instance.StoreDataToList(number);
        GameManager.instance.FieldName(obName);
    }
}
