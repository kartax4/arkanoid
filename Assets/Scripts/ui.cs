using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            textMeshProUGUI.text = "Siema";
            textMeshProUGUI.fontSize = 140;
            textMeshProUGUI.fontStyle = TMPro.FontStyles.Italic;
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;   
            textMeshProUGUI.color = Color.blue;
        }
    }
}
