using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
   public Vector3 value;

   public void UpdateValue (Vector3 number)
   {
    value += number;
   }

   public void ReplaceValue(Vector3 number)
   {
    value = number;
   }

   public void DisplayImage (Image img)
   {
 //   img.fillAmount = value;
   }

   public void DisplayNumber(Text txt)
   {
    txt.text = value.ToString();
   }
}
