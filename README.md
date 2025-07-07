# Project-Conquest
Tile-based tactical conquest game!


Players will spawn into a procedurally genrated map along with 1+ (max: 4...?) other computer generated "players". This map will have a variety of biomes including: plains, forests, mountains, tundras, deserts, oceans, etc. with players having the option to traverse the map in order to expand their kingdom.

_____________________________________________________________SETUP_____________________________________________________________

Initially, when spawned into the world the player will have their own tile, their capital. In their capital, players will have the ability to see the age of their kingdom, the population size, and their gold. Likewise, when on a tile players will see two action lists: Army and Invest. Under the army list players will have the ability to either move their army to a different tile, taking some amount of time, or to conscript a portion of the population to the army. In addtion to this, under the invest list players will have the ability to improve their education, an action which improves their weapons, transportation, and ability to traverse different biome types, and improve their gold reserve, an action which again can be used to improve a player's weapons and pay for a larger army.

On the bottom left corner of the screen players will see a counter with the year and the month players are currently in. This will appear on every screen players can traverse as the time table is one of the most important aspects of the game.

When expanding their kingdom, players can only move onto adjacent tiles, this action as well as other "movement" options will cost time, around 1 month. To successfully expand one's kingdom, a player must move a portion of their population to the desired tile. The population that they wish to move onto that space must check a few different boxes in order to "settle" the tile:
  - Intelligence, whether the population has a good enough understanding of the terrain to survive (Education)
  - Wealth Incentive, whether the population has a good enough reason to want to move to this tile (Gold)
  - Protection, whether the population has the ability to survive long enough to settle the land (Army)

This settling should take some reasonable amount of time to complete, however, once this is finished, this tile becomes apart of the player's kingdom.

___________________________________________________________GAMEPLAY__________________________________________________________

The goal for the game (at this stage of the project) is to control the board. When two kingdoms are adjacent to one another tensions will arise between players, to prepare for this CPUs will oftentime move larger portions of their armies to the edge of thier empire in order to more quickly mobilize in the event of an attack.

Assuming it is the player who strikes first, they can move their armies to an opponent controlled tile. Doing this will take some variable amount of time; with it taking longer the further the army has to travel/how big the army is, with the opposing player being notified when an army is being moved. They can then, likewise, move their own army to desired tile in order to prepare for "battle".

When two opposing armies meet on the same tile a battle begins.

To begin the battle, a sequence plays as we zoom onto the tile. There we'll see the two armies on opposing sides on a grid-based battlefied. The gameplay at this stage will resemble Pokemon Conquest. Up to 8(..?) soliders are positioned on the battlefield and both sides take turns moving and attacking. A battle is won or lost when the engaging army manages or fails to achieve the victory conditions, which vary by location. Different units have different advantages/disadvantages - greater mobility/lower damage, higher joint-damage/lower solo damage, etc. - however, the "home" kindgom will always be given an advantage (more desireable starting location, easier win-con, etc.), if an advantage is available. Assuming a defending kingdom's army is not there when an attacking kingdom arrives, the attacking kingdom automatically wins the tile. Once the tile is conquered, players will return back to the original map as the tile becomes the winning player's, and the opposing army is erased. (Vice-versa if it is defended). This gameplay loop will continue until the entire board is conquered. (At this stage of the game).

Players can upgrade their army by investing in their education and gold reserves. This can grant the given army better weapons and armor, letting them both give and take less damage respectively. Likewise, in the event that a player lacks an army or lacks the ability to get their army to a given tile for whatever reason they need, players are able to conscript portions of a tile's population into the army. Doing this will result in decreased "happiness" for the given tile and result in a baseline level army being drafted (could be higher depending on how the tile's "invest" stat), however at this stage in the project, there is just a chance it fails.

Though neglected being mentioned, even if a player's army wins, all killed units will remain dead.

____________________________________________________________FUTURE___________________________________________________________

- Religion
  - Different tiles will have the chance to be divinely inspired, starting a new religion. This could result in the spread
    of the religion depending on the kingdom's culture and their tolerance towards religious freedoms and depending on how
    much it spreads can affect the kingdom's culture.
  - Kingdoms that follow the same religion are less inclined to aggro others that follow that religion, however, if the
    kingdom of origin is weak enough, will become more inclinded to take the tile of origin for the religion.

- Culture
  - As time goes on and a kingdom gets older it will develop its own culture (Warmongers, peaceful, spiritual,
    nationalistic, etc.)
  - Kingdoms that follow the same culture are less likely to attack one another and vice-versa.

- Happiness
  - Kingdoms and more importantly tiles possess their own happiness level that is influenced by a variety of factors (newly
    acquired, low investment level, different culture, different religion, conscription level, etc.)
  - At low enough happiness rebellions are possible with a given tile forming its own kingdom. Depending on the happiness
    level of the adjacent tiles, they may also join the rellious kingdom into forming a new empire.

- Alliances/Mercenaries
  - Kingdoms may ally themselves or hire with different kingdoms that they are at a comfortable enough level with to use
    portions of their army in an attacks or operations they seek to enact.
  - Likewise, in the event of an alliance, kingdoms that are allied with one another will go to war together, whether this
    be defensive or offensive.





____________________________________________________________MOCKUP IMAGES___________________________________________________________

*Initial Spawn*
![IMG_2118](https://github.com/user-attachments/assets/2702927a-35aa-4148-8f15-bdac154a2f8a)

*2 In-Game Years*
![IMG_2119](https://github.com/user-attachments/assets/a3d3bc37-4567-4632-96ea-51080cf9e45b)

*Selecting Capital Tile*
![IMG_2120](https://github.com/user-attachments/assets/17365543-1fea-4d62-bc8b-3427d6ca4371)

*Capital Tile*
![IMG_2121](https://github.com/user-attachments/assets/d65efce4-b14a-41da-8466-93de35261e74)

*Selecting Enemy Tile*
![IMG_2122](https://github.com/user-attachments/assets/f4b5491a-4685-423e-9972-8b16931881d5)

*Questioning The Attack*
![IMG_2123](https://github.com/user-attachments/assets/f867d3d3-4787-4be8-88d2-3bd494bdc38e)
![IMG_2124](https://github.com/user-attachments/assets/461b6b6a-7942-4453-b582-6b34af444bb1)

*Battle Layout*
![IMG_2125](https://github.com/user-attachments/assets/06075b11-810d-47a0-8dbe-3e88bd4653af)
