using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text textComp;


    public void UpdateText(float val)
    {
        val = Mathf.FloorToInt(val);
        textComp.text = val.ToString();
    }
}   