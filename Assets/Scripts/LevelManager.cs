using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [Header("經驗值")]
    public Image imaExp;
    [Header("等級")]
    public TextMeshProUGUI lv;
    [Header("等級經驗值")]
    public TextMeshProUGUI lvExp;

    private int lvs = 1;
    private float exp = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print($"<color=#6699ff>{collision.name}</color>");
        if (collision.name.Contains("經驗值"))
        {
            collision.GetComponent<exps>().enabled = true;
        }
    }

    public void Addexp(float leExp)
    {
        exp += leExp;
        lvExp.text = exp + " /100";
        imaExp.fillAmount = exp / 100;
    }
    public float[] expNeed = {100,200,300 };
    List<float> expneed;
	private void les()
	{
		for (int a = 1 ; a < 100 ; a = a+1)
        {
            expneed.Add(a*100);
        }
	}
	
    

}
