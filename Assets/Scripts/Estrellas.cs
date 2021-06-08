using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    public ParticleSystem StarEmiter; 
    public int MaxStars; 
    public int FieldRadius; 
    public float MinimumStarSize; 
    public float MaximumStarSize; 
    public ParticleSystemShapeType StarFieldShape;

    void Start()
    {
        StarEmiter = GetComponent<ParticleSystem>();
        var mainModule = StarEmiter.main;
        mainModule.loop = true;
        mainModule.prewarm = true;
        mainModule.startSpeed = 0;
        mainModule.simulationSpace = ParticleSystemSimulationSpace.Local;
        mainModule.startLifetime = 1000000;
        var shapeModule = StarEmiter.shape;
        shapeModule.shapeType = StarFieldShape;

        mainModule.maxParticles = MaxStars;
        var shape = StarEmiter.shape;
        shape.radius = FieldRadius;
        mainModule.startSize = new ParticleSystem.MinMaxCurve(MinimumStarSize, MaximumStarSize);

        StarEmiter.Emit(MaxStars);
    }

}