using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI pressedButton;
    private string displayMessage;
    

    void Start()
    { 
        displayMessage = "Pulsa cualquiera de las cuatro flechas";
        pressedButton.text = displayMessage;
    }

    // Update is called once per frame
    void Update()
    {
        pressedButton.text = displayMessage;

        ShowMessage(KeyCode.RightArrow, displayMessage);
        ShowMessage(KeyCode.LeftArrow, displayMessage);
        ShowMessage(KeyCode.UpArrow, displayMessage);
        ShowMessage(KeyCode.DownArrow, displayMessage);
        ShowMessage(KeyCode.Space, displayMessage);

        
    }

    public void ShowMessage (KeyCode key, string text)
    {
       
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                displayMessage = "Derecha";
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                displayMessage = "Izquierda";
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                displayMessage = "Arriba";
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                displayMessage = "Abajo";
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                displayMessage = "¡Has pulsado espacio!";
            }
        

    }
}
