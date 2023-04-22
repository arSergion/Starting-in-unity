using UnityEngine;

public class EbanleLight : MonoBehaviour
{
    

    public Light _mainLight;

    private void Update() {
        if (Input.GetKeyUp(KeyCode.P))
        _mainLight.enabled = !_mainLight.enabled;
    }
}
