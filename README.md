Unity3D-ComponentPools
====================

Instantiate() and Destroy() can be expensive calls; it is often more performant to recycle GameObjects using an [object pool](http://answers.unity3d.com/questions/196413/gameobject-pool-to-avoid-performance-issues-in-ins.html) pattern.

Our pools focus on components and the scene hierarchy. With a scene hierarchy like this:

    Pool (has ParticlePool named "Explosion")
        Pooled object (has ParticleSystem)
        Pooled object (has ParticleSystem)

It's easy to find and recycle those particles:

    PoolManager.Get<ParticlePool>("Explosion").GetNextAt(Vector3.zero);

* The pool will move a particle system to the requested location.
* By default, the particles will play immediately.
* By default, new particle systems will be spawned when the pool is empty.
* Finished particles will be reclaimed automatically.

Pool structure is managed at runtime, using the scene hierarchy.

<dl>
<dt>PoolManager</dt>
<dd>Static class to easily find and use pools.</dd>

<dt>ParticlePool</dt>
<dd>Pool to manage ParticleSystem components.</dd>

<dt>TransformPool</dt>
<dd>Every GameObject has a transform, making this pool extremely versatile.</dd>
</dl>

It's easy to manage other components, including your own custom components, by creating a new class inheriting from `ComponentPool<T>`.
