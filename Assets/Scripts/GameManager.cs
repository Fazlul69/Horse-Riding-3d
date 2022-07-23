using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public List<int> storeNumberList = new List<int>();
    public List<string> ob = new List<string>();

    public Text firstPosTxt;
    public Text secondPosTxt;

    void Awake(){
        instance = this;
    }

    void Update(){
        Score();
    }

    public void StoreDataToList(int data){

        if(storeNumberList.Count < 3){
            storeNumberList.Add(data);
        } 
    }
    public void FieldName(string d)
    {
        if(ob.Count <3 ){
            ob.Add(d);
        }

    }

    public void GameMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Score()
    {
       string firstPos = PlayerPrefs.GetString("1st");
       string secondPos = PlayerPrefs.GetString("2nd");

       firstPosTxt.text = firstPos;
       secondPosTxt.text = secondPos;
    }
}
