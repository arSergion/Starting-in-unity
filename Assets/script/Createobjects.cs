using UnityEngine;
public class Createobjects : MonoBehaviour
{

    public GameObject[] obj;
    private void Start() {
        for (int i = 0; i < 5; i++) {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), RandomNumber(), RandomNumber()));
        }
        
        
    }
    private int RandomNumber() {
        return Random.Range(0, 10);
    }
}
