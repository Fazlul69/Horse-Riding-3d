using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Numbergenerator : MonoBehaviour
{
    public GameObject[] textBox;
    private int odds;
    public List<int> oddsNumber = new List<int> ();


    public void RandonGenerator()
    {
        for (int i = 0; i < odds; i++)
        {
            oddsNumber.Add(i);
        }
        oddsNumber = oddsNumber.OrderBy(tvz => System.Guid.NewGuid()).ToList();

        for(int i = 0; i < oddsNumber.Count; i++){
            textBox[i].GetComponent<Text>().text = ""+ oddsNumber[i];
        }
        
    }
}
