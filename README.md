# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
Hello World!

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. Why are r, g, and b floats?
   
They are floats because colors need numbers between 0.0 and 1.0. Floats can have decimals, but ints, bools, or strings cannot.

2. Why is _bounces an int?

_bounces counts how many times the ball bounced. Bounce counts are whole numbers, so int is best.

3. What did an error tell you?
   
In Step 2, I wrote r += 0.1 without f. Unity gave an error because r is a float. Adding f like 0.1f fixed it.


### W3
1. I belong to Table 5, and I will be answering question 1.

Q: You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.

The input will include float x and float y. Float x refers to the moment when player's finger touches the screen. Float y refers to the moment when player's finger leaves the screen. In the body part of the method, we will substract y from x to obtain float z. If z is greater than 0.2s, then bool whetherHit equals true. The boolean type whetherHit variable will be the output.

Input: float x (touch time); float y (leave time)

Output type: boolean

2. Class is a family recipe for how to make and present a dish that has been passed down through different generations. Components are the printed version of the recipe in a cookbook. Method is the cooking steps for this dish. Member variables are the ingredients of this dish.

3. The balls get extremely bright in the Scene if they bounce too many times because every time they hit something, their color gets brighter. In the BallW3 script, I wrote code that increases the pink, green, and blue values a little bit each time the ball collides. If the ball keeps bouncing, these values add up, and the color becomes very bright. That’s why after many bounces, the balls look almost glowing or super bright.

How my code works

Every bounce, _bounces increases and shows on screen.
Red (r) goes up by 0.1 and resets to 0 if it gets over 1.
Green (g) goes down by 0.1 and resets to 1 if it gets below 0.
Blue (b) multiplies by 1.2 and resets to 0.1 if it reaches 1.
Brightness is the average of r, g, b and shows on screen.
The ball changes color every bounce, and the bounce count and brightness update correctly.

### W4

table 5

Line 5: _moveSpeed is a member variable, and the type is float. It is marked with [SerializeField] so it can be edited in Unity’s Inspector even though it is private. This variable controls how fast the cat moves.

Line 22: transform is a Component of the cat GameObject. This line is calling the Translate method. The method parameters are (0, 0, translation), which means it moves the cat forward or backward on the z-axis, but does not move it on the x-axis or y-axis.

Line 25: _rigidBody is a Component of type Rigidbody. This line is setting the linearVelocity property. The type of linearVelocity is Vector3, which stores speed in the x, y, and z directions. The new value keeps the x and z speeds the same but sets the y speed to 0, so the cat’s jump starts from zero vertical speed.

We talked about which objects need a Rigidbody and which should have “Is Trigger” checked. We decided:

Cat: add a Rigidbody so it can move and kick the ball. Do not check Is Trigger.

SoccerBall: add a Rigidbody so it can move and bounce. Do not check Is Trigger.

Goal: do not add a Rigidbody. Check Is Trigger so the ball can go through the Goal and we can detect it.

We also used Freeze Rotation on the X and Z axes for the Cat and SoccerBall so they would not fall over.

After that, we added the BounceOffWall Component to the Cat and SoccerBall. We connected the missing settings and adjusted the Bounce Force. Then we coded Step 1 and tested it. At first, the ball did not bounce correctly, so we fixed the Rigidbody and collider size. After that, the Cat could kick the ball and the ball bounced off the walls.

Finally, when the ball went into the Goal, we saw the Debug message in the Console. The goal celebration effect played, and the points text and time since last goal text updated correctly.

Reflection: Our solution worked well after fixing the Rigidbody and collider settings. Adding Rigidbody to the moving objects and Is Trigger to the Goal made the physics and goal detection work perfectly.

### W5
Question: What is the difference between transform.position and transform.localPosition, and when should I use each?

transform.position gives the object’s position in world space and transform.localPosition gives the object’s position relative to its parent.

Use localPosition when you want to move or place an object based on its parent, and use position when you want to place it in the scene regardless of the parent.

I learned this helps me control objects more precisely in hierarchical setups.

Member Variables: 

public Transform target; → target GameObject the deer will walk to; private NavMeshAgent agent; → reference to the deer’s NavMeshAgent

Methods:

Start() → get the NavMeshAgent using GetComponent<NavMeshAgent>()

Update() → set the deer’s destination to target.position every frame

Notes:

target is a Transform so it can be assigned in the Inspector

NavMeshAgent handles movement and pathfinding automatically

### W6
【Other tools】

https://docs.google.com/document/d/1exNqQE_zGuOoztND9FT3ldDwkXjJ6m8a8oRDWERaMyg/edit?usp=sharing

1. What member variables does this class need?
   
player (Transform) – reference to the player

speed (float) – movement speed of the bat

isChasing (bool) – whether the bat is chasing the player

reachDistance (float) – distance to trigger reaction

2. What methods does this class need? Should it be something Unity provides, or one you write?
   
Unity-provided methods: Start(), Update()

Custom methods: StartChasing(), StopChasing(), OnReachPlayer()

3. What should the method(s) do?
   
StartChasing() – enable chasing the player

StopChasing() – stop chasing the player

OnReachPlayer() – show a message when bat reaches the player

Update() – move the bat toward the player if isChasing is true

Start() – used temporarily to test chasing when the game starts

### W6
activity1

https://docs.google.com/document/d/1TsVke4FYWiPQJM1o9TWKmZdGuEjed6uXTYwZxrXfC3I/edit?usp=sharing

In Activity 1, I contributed by helping design the game engineering plan and outlining the systems for Environment.

activity 2

The original code in Step 2 used:

transform.position += movement * Vector3.forward * _moveSpeed * Time.deltaTime;

Problem:

Vector3.forward is always pointing along the world Z-axis, so the Muskrat moves in a fixed direction regardless of which way it is facing.

This ignores the Muskrat’s rotation, causing movement to feel disconnected from its orientation.

Solution:

Replace with:

transform.position += movement * transform.forward * _moveSpeed * Time.deltaTime;

transform.forward points in the Muskrat’s forward direction in world space, so movement respects the rotation and feels natural.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
