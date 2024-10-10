using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using Firebase.Auth;

public class Vxod : MonoBehaviour
{
    public InputField logInput;
    public InputField PassInput;
    public Button LoginBtn;
    public Button RegBtn;
    //FirebaseAuth auth;
    // Start is called before the first frame update
    void Start()
    {
        //auth = FirebaseAuth.DefaultInstance;
        LoginBtn.onClick.AddListener(delegate {
            login();
        });

        RegBtn.onClick.AddListener(delegate {
            register();
        });
    }

    private void login()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void register()
    {
        //auth.CreateUserWithEmailAndPasswordAsync(logInput.text, PassInput.text);
    }
}