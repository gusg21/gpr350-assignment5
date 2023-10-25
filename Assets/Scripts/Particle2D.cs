using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public Vector3 velocity;
    public float damping = 0.999f;
    public Vector3 acceleration;
    public Vector3 gravity = new Vector3(0f, -9.8f, 0f);
    public float inverseMass = 1.0f;
    public Vector3 accumulatedForces { get; private set; }

    public void FixedUpdate()
    {
        DoFixedUpdate(Time.fixedDeltaTime);
    }

    public void DoFixedUpdate(float dt)
    {
        Integrator.Integrate(this, dt);
        ClearForces();
    }

    public void ClearForces()
    {
        accumulatedForces = Vector3.zero;
    }

    public void AddForce(Vector3 force)
    {
        accumulatedForces += force;
    }
}
