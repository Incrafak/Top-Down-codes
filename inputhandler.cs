using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputhandler : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;

    public void ValidateInput()
    {
        string input = inputField.text;

        if (input.Length < 1)
        {
            resultText.text = "ERROR";
            resultText.color = Color.red;
        }
        else
        {
            resultText.text = "Jdeme na to!";
            resultText.color = Color.green;
            Thread.Sleep(2000);
            SceneManager.LoadScene("OHRADA");
        }

    }
}

