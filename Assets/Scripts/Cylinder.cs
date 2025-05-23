using UnityEngine;

public class Cylinder : Shape // INHERITANCE
{
    private void Start()
    {
        scoreValue = 15;
    }

    public override void OnClick() // POLYMORPHISM
    {
        ShootShape();
    }
}
