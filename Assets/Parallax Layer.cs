using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;
    public float left = -19f;
    public Vector3 right = new Vector3(19f, 0f, 0f);
    public float rate = 1f;
    public static float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * speed * rate;
            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
