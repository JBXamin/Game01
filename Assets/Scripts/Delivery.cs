using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public static int carLives = 5;
    [SerializeField]  Color32 haspackagecol = new Color32 (1,1,1,1);
    [SerializeField]  Color32 nopackagecol = new Color32 (1,1,1,1);
    bool HasPackage;
    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    [SerializeField] float destrodel = 0.5f;
    private void OnCollisionEnter2D(Collision2D other) {
        carLives--;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !HasPackage){
        HasPackage = true;
        spriteRenderer.color = haspackagecol;
        Destroy(other.gameObject,destrodel);
        }
        if(other.tag == "Customer" && HasPackage){
            Manager.deli = true;
            HasPackage=false;
            spriteRenderer.color = nopackagecol;
        }
    }
}
