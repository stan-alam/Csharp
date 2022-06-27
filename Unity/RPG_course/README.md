## Build Combat for Role Playing Game in Unity using C#

```text

Build Combat for Role Playing Game (RPG) in Unity. Tutorials Cover Code Architecture & Video Game Design.

Role Playing Games can be complex to create, with many interacting gameplay systems. We make it easy for you!
Learn, step-by-step, how to make the foundations of any good RPG combat system – from scratch.

In this course we’re focusing on the core of any great RPG, giving your players a fun combat moment in a well
crafted level, based upon a solid game design, built using a robust code architecture. You will follow our project,
but also make the game entirely your own.

This highly acclaimed course was over 200% funded on Kickstarter, and is designed for intermediate users of Unity.
We recommend you take at least the first half of our Complete Unity Developer 2D or 3D, or equivalent, as a pre-requisite.

The course can be a standalone course, or can be taken as the first part in our RPG series. The three other
separate courses in this series teach the Inventory system, Shops and Abilities, and Dialogue and Quests.

This is a highly realistic and comprehensive introduction to real game development. We’ll be taking you through
our process step-by-step, with all decisions justified and all avenues explored.

Fancy something a little different to get started? Check out GameDev’s other courses, just look for the green logo as your guide.

We will be dealing with player movement, NavMesh navigation, AI pathfinding, save and loading systems, basic pick ups,
using asset packs, debug code, making particle effects and more. We’ll also give you a robust code architecture for
managing more complex projects by setting up namespaces.

You’ll need a basic grasp of Unity and C# before you get start, from there we’ll be teaching you more advanced programming
techniques such as C# delegates, interfaces, co-routines and more.

Building an RPG is an amazing way to level-up your game development skills, so why not join us and get started improving
your game development right now?

What you’ll learn

Create core combat mechanics for melee, ranged and special attacks.
More advanced C# techniques such as interfaces, delegates, and co-routines.
Create pathfinding systems and patrol paths for enemies and NPCs.
Make a detailed level with terrain, enemies, triggers, lighting, particles and props.
Balance the player and enemy stats (eg. health, damage, movement, attack speed, and more).
Advanced game design, project management and code architecture strategies.



Introduction & Setup
1 Welcome To The Course
2 Install Unity 20183
3 Install Visual Studio Code
4 Not Making Intellisense
5 Quick Game Design Overview
6 Architectural Overview
7 Community & Support

Basic Movement
8 Section Overview
9 Create A Simple Sandbox
10 Move Using Nav Mesh Agent
11 Refining Your Nav Mesh
12 Introduction To Raycasting
13 Implement Click
14 Create A Fixed Follow Camera
15 Animation Blend Trees
16 Match Animation To Movement
17 Basic Movement Tweaks
18 Project Folder Structure

High Level Game Design
19 Section Intro
20 Page Game Design Document
21 The Player Experience
22 First Draft Of Your GDD

Basic Combat
23 Section Overview
24 Separating The Control Layer
25 Namespaces To See Dependencies
26 Raycasting For Components
27 Implementing Action Priority
28 Move Within Range
29 Cancelling Combat With Movement
30 Decoupling Dependency Cycles
31 Dependency Inversion With Interfaces
32 Add Attack Animation
33 Trigger Animation In Code
34 Throttling Our Attacks
35 Taking Damage
36 Nested Prefabs And Variants
37 Using Prefab Variants
38 Any State Animations
39 Trigger Death Animation
40 Stop Attacking Already
41 Look Them In The Eyes
42 Ignore Dead Enemies
43 Bugs What Bugs

Enemy AI
44 Section Overview
45 Calculating AI Chase Distance
46 Swappable Control Systems
47 Disable Control When Dead
48 Visualising With Gizmos
49 AI Guarding Behavior
50 Thats Some Suspicious Behavior
51 Visualizing Waypoints
52 Waypoint Loops
53 Patrolling Behavior
54 Dwelling At Waypoints

First Moment
55 Section Overview First Moment
56 Design A Moment
57 Sketch Your Moment
58 Tips To Improve Workflow
59 Craft The Environment
60 Hits
61 Tweak Enemy Patrol
62 Cinemachine Follow Camera
63 Make Cinematic Sequence
64 Trigger Cinemachine Cut Scene
65 The Observer Pattern In C Sharp
66 Player Input In Cutscenes

Scene Management
67 Section Overview
68 Make A Second Scene
69 Scene Loading Portals
70 How Coroutines Work
71 Wait For Scene To Load
72 Player Spawn Point
73 Cross Scene References
74 Canvas Groups For Fading
75 Nested Coroutines For Fading
76 Avoiding The Singleton Pattern

Saving Asset Pack
77 Section Overview Saving Asset Pack
78 The Saving System Overview
79 Triggering Saving And Loading
80 Saveable Components And GameObjects
81 Challenge Saveable Health
82 Checkpoints Between Scenes
83 Loading The Saved Scene
84 BONUS Capturing Multiple Parameters
85 BONUS Runtime Objects

Saving System
86 Saving Multiple Scenes
87 Checkpoints Between Scenes
88 ISaveable Components
89 Deduplicating UUIDs
90 Restoring Health
91 Reloading The Last Scene
92 Fading Before Scene Load
93 Skip Or Continue
94 Section Overview Saving System
95 Save System Design
96 Overview Of Binary Serialization
97 File Paths In C
98 Understanding Unicode
99 Filestream Read And Write In C
100 Converting To Binary In C
101 BinaryFormatter For Serialization
102 Saveable Entities
103 Generating UUIDs In C
104 Editing SerializedFields
105 Serializing With SaveableEntities
106 Saving Multiple Scenes

Simple Weapons
107 Section Overview Simple Weapons
108 Equip A Weapon
109 Animator Override Controller
110 Creating Scriptable Objects
111 Unarmed As A Weapon
112 Basic Weapon Pickup
113 Left Handed Weapons
114 Make A Weapon Projectile
115 Shoot Projectiles
116 Damage From Projectiles
117 Trails & Prefab Variants
118 Destroy Old Weapon
119 Improve Projectile Behavior
120 Fireball Weapon & Pickup
121 Fireball Particle System
122 Projectile Impact Effect
123 Destroy The Unwanted
124 Resetting The Default Animator
125 Dynamic Resource Loading
126 Saving Weapon Choice
127 Pickup Respawning

Character Stats
128 Progression Design
129 Progression Scriptable Object
130 Looking Up The Health Stat
131 Debug Health Display
132 Enemy Health Display
133 Awarding Experience Points
134 Editing Scriptable Object Files
135 Finding A Stat By Enum
136 Saving Experience Points
137 Displaying Experience
138 Performant Lookups With Dictionaries
139 Levelling Up
140 Displaying The Level
141 Squashing Health Bugs
142 Events And Delegates
143 Delegates And Actions For Leveling Up
144 Saving Race Conditions
145 Level Up Events And Particle Effects
146 Damage Progression
147 Extensible Modifier System
148 Percentage Modifiers
149 Data Hazards And Race Conditions
150 Hunting Down Race Conditions
151 Awake vs Start
152 Lazy Initialisation
153 Progression Stats Spreadsheet

Final Polish
154 Configurable Cursors
155 Cursors And UI
156 Generic Raycastable Components
157 Cursor Type With IRaycastable
158 Raycast Sorting
159 Raycasting To A NavMesh
160 Calculating A NavMesh Path
161 In Game UI
162 Text Fading Animation
163 Spawning Damage Text
164 Using Unity Events
165 Updating The Damage Text Value
166 Unity Events With Parameters
167 Health Bar UI
168 Updating The Health Bar Scale
169 Disabling Empty Health Bars
170 Fixing The Fader
171 Coroutine Race Conditions
172 Camera Facing LateUpdate Fix
173 Sound Effects And UnityEvents
174 Weapon Prefab Refactor
175 Fighter To Weapon Communication
176 Boom Microphone Audio Listener
177 Health Pickup Hack
178 Visual Polish Audit
179 Visual Polish Part 1
180 Visual Polish
181 Visual Polish
182 Combat Moment Fine Tuning
183 Bug Attacking Distant Enemies
184 Enemy AI Agro
185 Enemy Mob Mechanics
186 Bug Shooting Over Water
187 You've Finished The Course

Continuing Your GameDev Journey
188 Bonus Lecture
189 Coupon For Original Course Content
