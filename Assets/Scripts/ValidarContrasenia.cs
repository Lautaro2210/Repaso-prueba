using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour {

	string contraseñacorrecta;
	string contraseñaUsuario;
	public Text ingresoUsuario;
	public Text textomsj;
	public GameObject cartelitomsj;

	// Use this for initialization
	void Start () {
		contraseñacorrecta = "12345";
		cartelitomsj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ValidarContraseña()
    {
		contraseñaUsuario = ingresoUsuario.text;
		if (contraseñaUsuario == contraseñacorrecta)
        {
			cartelitomsj.SetActive(true);
			textomsj.text = "Bienvenid";
			Debug.Log("Bienvenido");
        }
        else
        {
			cartelitomsj.SetActive(true);
			textomsj.text = "Contraseña incorrecta";
			Debug.Log("Contraseña Incorrecta");
        }
    }
}
