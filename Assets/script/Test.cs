using UnityEngine;
public class Test : MonoBehaviour
{  
    public GameObject[] objs = new GameObject[3];
    public Transform[] transforms = new Transform[3];
    public float speed = 5.0f;
    public float rotateSpeed = 5.0f;
    private void Update() {
        for (int i = 0; i < transforms.Length; i++){
            if (transforms[i] ==null)
                continue;
            transforms[i].Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            transforms[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);
            
            float posX = transforms[i].position.x;
            if (posX > 10f && transforms[i].gameObject.name == "Cube")
                Destroy(transforms[i].gameObject);

        }


   }

    
    
}
