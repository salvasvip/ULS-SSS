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
       
        // Debug.LogWarning("Box shape Particle System types are not currently supported!,neither are custom meshes or cones");
        StarEmiter.loop = true;
        var mainModule = StarEmiter.main;
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