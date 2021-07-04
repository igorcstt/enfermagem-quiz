using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UsuarioNameSpace{
public class Usuario : MonoBehaviour
{
    private String dsEmail;
    private String nuSenha;
    private String nmApelido;
    
    public String DsEmail { get => dsEmail; set => dsEmail = value; }
    public string NuSenha { get => nuSenha; set => nuSenha = value; }
    public string NmApelido { get => nmApelido; set => nmApelido = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}