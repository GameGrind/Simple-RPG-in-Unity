# Simple RPG in Unity

[![GitHub release](https://img.shields.io/github/release/gamegrind/simple-rpg-in-unity.svg)](https://github.com/GameGrind/Simple-RPG-in-Unity/releases/tag/v1.0.0)

Unity project for the Simple RPG series on GameGrind.

The Simple RPG is a very simple RPG built in Unity as part of a training course on Youtube ([here's the channel](http://www.youtube.com/gamegrind)). The RPG was designed to simply teach basic concepts of RPGs, while making a decently functioning game.

**This project was used as a way to teach the basics of programming in C# and building various systems in Unity. Not intended for a complete game, but that's up to you!**

## Systems and Mechanics
Along the way we created various systems and mechanics for the game so I'll just list a few here.

### Inventory and Equipment
The big one is an inventory and equipment system. You can create items in the JSON database, assign them as item drops in monster loot tables, create equipment that you can use to attack enemies, easily extend existing weapons to create new weapons, and so on. Equipment and consumables can be interacted with from the UI.

![](https://i.imgur.com/lK8g4KU.gif)

### Dialogue
The next system is the simple dialogue system. Nothing fancy here, just a sequential dialogue that you can add to any interactable object.

![](https://i.imgur.com/JsivJMB.gif)

### Melee and Projectile Combat
The combat is rather basic. This is simply due to my lack of imagination on what would make for simple combat. Melee and projectile weapons exist, but in a very basic form. A sword and staff exist for you to extend and build on top of.

![](https://i.imgur.com/VEu0zrA.gif)

### Weighted Loot Tables
You can create weighted loot tables for specific monsters. The tables allow you to roll a die to determine what item will drop, based on rarity ratings.

![](https://i.imgur.com/Cfl74cb.gif)


### Quests
The questing system allows you to create custom quests and quest givers that can assign various tasks to the player. The player will have to complete the tasks in whatever order they would like. Returning to the quest giver before completion will prompt specific dialogue, while returning after completion will grant you your reward and specific dialogue. The custom quests and tasks are very easy to extend to create whatever you can imagine.

![](https://i.imgur.com/bC6fz3y.gif)

### Teleportation System (extensible interaction system)
The interactable system is used for enemies, NPCs (quest givers, dialogue guys, whatever), player movement, examining objects, and everything inbetween. As an example of it doing anything, here's a teleportation network using weird water wells:

![](https://i.imgur.com/BHatq8d.gif)

### Leveling and Stats
At the foundation of the lacking combat is a pretty cool stat system. Stats can be easily defined, buffed, debuffed, and used for various calculations. The equipment system uses the buff/debuff system for changing stats, but it can be used for consumables, quest rewards, or whatever you can think of.

The leveling system is barebones, but it allows you to grant the player experience for various tasks (killing enemies, completing quests). If the treshold for leveling is reached, a level is gained. That just continues for as long as you would like.

![](http://oi64.tinypic.com/m9y5ig.jpg)

You can see the stats and levels here. The progress bar (the circle) shows you how much experience you need to gain a level. You can see your player's stats and even unequip your currently equipped weapon.

**Note: This UI element is using the default Unity Text engine while the rest of the UI was upgraded to TextMesh Pro. This will be fixed**

So that's a few of the big systems that we've added throughout the course. While the course is considered to be finished, I have plans to keep fixing a few things, adding in a couple of other features, and trying to keep it going. 

The game's simplicity is a double-edged sword. There are better, more efficient ways to handle a ton of the stuff that we covered, but it would've taken 60 lessons as opposed to <30. For instance, using an object pooling system would've made since in multiple places (monster spawners, UI repopulation). These are things I may rewrite as time goes on. We'll see.
