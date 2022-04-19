using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
    [SerializeField] InputField user;
    [SerializeField] InputField password;

    public void OnLoginButtonPress()
    {
        string userStr = user.text;
        string passwordStr = password.text;
        Debug.Log("Login con user " + userStr + " y password " + passwordStr);
    }
}
