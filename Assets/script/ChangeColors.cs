using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
  private MeshRenderer _mesh;
  private void Awake() {
    _mesh = GetComponent<MeshRenderer>();
  }

  private void Update() {
    if(Input.GetKeyDown(KeyCode.U))
        _mesh.material.color = Color.green;
    if(Input.GetKeyDown(KeyCode.I))
        _mesh.material.color = Color.red;
    if(Input.GetKeyDown(KeyCode.O))
        _mesh.material.color = Color.blue;
    if(Input.GetKeyDown(KeyCode.Y))
        _mesh.material.color = Color.black;
  }
}
