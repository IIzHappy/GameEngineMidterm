Game
Implemented:
- Player can move and jump, can add multiple players, keybinds are editable for each player (some movement code was taken from earlier this semester)
- Enemies have a move function but wasn't finished, when hit by a bubble move function can't be called, trapped state lasts for editable period of time
- When a bubble collides with an enemy that isn't trapped yet, it will trap that enemy and allow it to be defeated
- Enemy manager that spawns enemies at start of wave and keeps track of enemies that are still alive
Not yet implemented:
- Player could spawn bubbles which would move in the direction player is facing
- Enemies could move around differently depending on the type and give players points upon defeat

Object Oriented Programming
Inheritance: There is a base Enemy class that has the basic functions like moving, getting trapped, and being defeated which are needed for all child classes.
Polymorphism: The base Enemy class calls a move function which would be overridden by child classes to create different movement behaviours for different enemy types
Encapsulation: The Enemy manager keeps track of all enemies that are currently alive. Enemies spawned/defeated will call AddEnemy() and EnemyDeath() and have the manager makes changes the list of current enemies

Singleton Pattern
The Enemy manager is a Singleton as it's needed to make sure players can't skip any levels
- Spawns and keeps track of enemies
unfinished:
- Would spawn certain enemies based on the level
- When all enemies are defeated, the next level can start (game just ends right now)
- When new level is loaded, could spawn the enemies from that level

Factory Pattern
- Each enemy type has a spawner that sets up everything needed when they're initialized
- The enemy manager runs the spawning at each level (multiple levels not implemented)
- Each level would have spawners and how many to spawn
- Enemy manager calls the spawners' SpawnEnemy() functions when it receives the info from each level
