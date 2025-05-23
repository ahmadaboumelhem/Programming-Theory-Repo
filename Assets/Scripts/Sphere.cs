using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    private void Start()
    {
        scoreValue = 5;
    }

    public override void OnClick() // POLYMORPHISM
    {
        DropShape();
    }
}
