using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCover : MonoBehaviour
{
    [Header("Inscribed")]
    public Sprite[] cloudSprites;
    public int numClouds = 40;
    public Vector3 minPos = new Vector3(-20, -5, -5);
    public Vector3 maxPos = new Vector3(300, 40, 5);
    [Tooltip("For scaleRange, x is the min value, and y is the max value.")]
    public Vector2 scaleRange = new Vector2(1, 4);

    // Start is called before the first frame update
    void Start()
    {
        Transform parentTrans = this.transform;
        GameObject cloudGo;
        Transform cloudTrans;
        SpriteRenderer sRend;
        float scaleMult;
        for ( int i = 0; i < numClouds; i++)
        {
            cloudGo = new GameObject();
            cloudTrans = cloudGo.transform;
            sRend = cloudGo.AddComponent<SpriteRenderer>();

            int spriteNum = Random.Range(0, cloudSprites.Length);
            sRend.sprite = cloudSprites[spriteNum];

            cloudTrans.position = RandomPos();
            cloudTrans.SetParent(parentTrans, true);

            scaleMult = Random.Range(scaleRange.x, scaleRange.y);
            cloudTrans.localScale = Vector3.one * scaleMult;
        }
    }

    Vector3 RandomPos()
    {
        Vector3 pos = new Vector3();
        pos.x = Random.Range(minPos.x, maxPos.x);
        pos.y = Random.Range(minPos.y, maxPos.y);
        pos.z = Random.Range(minPos.z, maxPos.z);
        return pos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
