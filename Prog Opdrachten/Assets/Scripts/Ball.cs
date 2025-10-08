using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    void Start()
    {
        {
            for (int i = 0; i < 100; i++)
            {
                Color color = RandomColor();
                Vector3 randPos = RandomPosition(-10f, 10f);
                GameObject ball = CreateBall(color, randPos);
                Destroy(ball,3f);
            }
        }

    }

    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material mat = ball.GetComponent<MeshRenderer>().material;

        // voor CORE pipeline
        mat.SetColor("_Color", c);

        //Voor URP
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        

        return ball;

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Vector3 spawnPosition = Vector3.zero; // You can change this to any desired position
            GameObject ball = CreateBall(RandomColor(), spawnPosition);
            DestroyBall(ball);

            elapsedTime = 0f;
        }
    }

    
    private void DestroyBall(GameObject ball)
    {
        Destroy(ball,3f);
    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }

    private Vector3 RandomPosition(float min, float max)
{
    float x = Random.Range(min, max);
    float y = Random.Range(min, max);
    float z = Random.Range(min, max);
    return new Vector3(x, y, z);
}
}
