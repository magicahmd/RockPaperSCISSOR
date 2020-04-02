# RockPaperSCISSOR

This program has two classes: Player & Game.

## Player Class

#### Player Properties:
- **name**
- **score**
- **turn**

#### Player Creation:
```
Player player = new Player("Ahmad");
```

#### Player Methods:
- **setTurn(Rock/Paper/Scissor):** to make the player choose a specific turn.
- **randomTurn:** to make the player choose a random turn 

## Game Class

#### Game Properties:
- **iterations**
- **Player player1**
- **Player player2**
- **static boolean chances:** 2d array for all the possibilites:
```
chances = {
            {null, false, true},
            {true, null, false},
            {false, true, null}
          }
          
* true => player 1 wins / player 2 loses.
* fales => player 2 wins / player 1 loses.
* null => player 1 & player 2 tie.
```

#### Player Creation:
```
Game game = new Game(50, new Player("Ahmad"), new Player("Ali"));
```

#### Game Methods:
- **playGame():** to start the game and play (n) times.
- **playRound():** play one round and increment the winner score.
- **static checkRoundWinner(player1Turn, player2Turn):**
check who's the winner by passing the index of the choosen turns to chances[player1Turn, player2Turn] 
- **printRound():** to display each player turn in one round and the winner.
- **getWinnerPlayer():** return the player who has higher score.
- **getLoserPlayer():** return the player who has lower score.