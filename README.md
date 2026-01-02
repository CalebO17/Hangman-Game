# Hangman Game

## A functioning hangman game developed in C# as a final assignment for COMP1026 (GUI Application Development with C#.NET)

This project uses a C# Windows Form Application to create a functioning hangman game that is playable with 2 players

## Tech Stack

- C# (.NET 8, Windows Forms)
- Visual Studio

## Features

- Hangman gameplay with 2 players
- High score tracking using PlayerPrefs
- A visually pleasing UI to make the gameplay experience more enjoyable
- Replayable game loop

## Installation

Make sure you have Visual Studio installed to run the C# `.sln` file.

To install the Hangman Game, you must first clone the repository to your local PC.

![White text on a black background that showcases cloning a github repo using the command prompt. The command is "git clone https://github.com/CalebO17/Hangman-Game](https://cdn.discordapp.com/attachments/1359281286325469375/1456700655291863111/image.png?ex=695951b4&is=69580034&hm=4bf233a499a7368e35a992727118fa831ea4bc6cafd45d1b709a54f07d43d1ec&)

```bash
  git clone https://github.com/CalebO17/Hangman-Game
```

After cloning the repository, you simply need to run the project and play the game! You can either run the .exe file by opening up the project in Visual Studio and clicking build, then going to your bin/Debug/net8.0-windows folder and clicking it, or you can simply open the `.sln` file, and click the green arrow at the top of the screen.

![Green arrow with the text "HangmanAssignment" next to it.](https://cdn.discordapp.com/attachments/1359281286325469375/1456701170377560174/image.png?ex=6959522f&is=695800af&hm=6bd6ffc4424e315fce297e029cc671ce5df35ae50c42956bdd29f64d7f5d9a3d&)

## How to play

After successfuly installing and running the software, you will be greeted with a title screen with a "Start Game" button and a button to display the high score.

![Hangman game title screen with Start Game and Display High Score buttons."](https://cdn.discordapp.com/attachments/1359281286325469375/1456701421838794882/image.png?ex=6959526b&is=695800eb&hm=adacf7e2cfa4b4a36a085c82e02ee1254573ed616ba730ba372f840b648a3b0f&)

If you click the "Display high score" button, it will simply display the name and score of the user with the highest score.

![Title screen with Start Game button and visible message displaying that a user called "Me" has 2 wins](https://cdn.discordapp.com/attachments/1359281286325469375/1456702347584471266/image.png?ex=69595347&is=695801c7&hm=03206e4fe153754d7f7bb36ba49fa8f1d492cbb4ec478a4cdd1796d3bfa47581&)

After clicking the "Start Game" button, you will be greeted with a screen for both players to enter their information.

- Name
- Age
- Gender

[Player setup screen with input fields for two players name, age, and gender, as well as a submit button.](https://cdn.discordapp.com/attachments/1359281286325469375/1456703760146501714/image.png?ex=69595498&is=69580318&hm=83f52fce6a1e8835256f76452cb5c2bc6bc84fba74f97118d9a13363064790fd&)

Once all player info is entered, the game will commence and a player will randomly be chosen as the one to choose the word.
[Choose word screen with a Message Box telling "Jeff" to enter a word and the other player to look away](https://cdn.discordapp.com/attachments/1359281286325469375/1456704980206489620/Screenshot_2026-01-02_124429.png?ex=695955bb&is=6958043b&hm=2ecb78310063ed3983ec25f84386351e625bdc17b3a801500db29094debd6f01&)

Once a word is chosen, the game will commence and the second player can begin to guess letters.[Game cycle screen showcasing 0 letters have been guessed, the word is four letters long, along with a Message Box stating "Your word is FEAR, now tell the other player that they can look again"](https://cdn.discordapp.com/attachments/1359281286325469375/1456705507552399552/image.png?ex=69595639&is=695804b9&hm=6a453103ab0092954047f58eb05eb526d535074b8a6109dc442ae0d2014d30eb&)

Once a player guesses a letter, two things can happen

- The letter is correct

If the letter is correct, the user will be notified they guessed a correct letter, and that letter will be put in the correct blank space in the UI.[Game cycle screen showcasing the letter A has been guessed and a Message Box has appeared with the text "Correct!"](https://cdn.discordapp.com/attachments/1359281286325469375/1456706298279366676/image.png?ex=695956f5&is=69580575&hm=2b55f9a75491937c111d456b3ddf0042e94c7cb867d5934fd614ed8d723081e3&)

- The letter is incorrect

If the letter is incorrect, the user will be notified they guessed a incorrect letter, and a body part will be added to the Hangman.[Game cycle screen showcasing the letter L has been guessed. It was incorrect, so a foot has now appeared in the hangman area.](https://cdn.discordapp.com/attachments/1359281286325469375/1456706399726862518/image.png?ex=6959570d&is=6958058d&hm=a169d3d7240fffe97c77d23ccb849105ea966928a45e82069bda8b4bc43e24eb&)

6 incorrect guesses and the word chooser will win! If the guesser correctly guesses all the letters, they win! Once the game ends, it will state who the winner is, the scoreboard will be updated, and the game will ask if the users want to play again. If they click yes, the game cycle will begin again. If they click no, they will be redirected to the title screen.[Game cycle screen showcasing the entire word "Fear" has been guessed and "John" has won. A popup message is asking if the users want to play again, and the scoreboard now showcases John has 1 win](https://cdn.discordapp.com/attachments/1359281286325469375/1456708029675212965/image.png?ex=69595892&is=69580712&hm=f4267de4c57c903bfd8edf626a4fb48b84e62244b8f0de8b297b5b2833d6e30f&)

## Future Improvements

- Sound effects
- UI improvements
- Multiple forms instead of one form with assets constantly changing visibility

## Troubleshooting

- Ensure Visual Studio is installed with **.NET desktop development**
- Ensure the project is **.NET 8.0**
- Ensure all user info is correctly entered when prompted

# License

MIT License

Copyright (c) [2025] [Caleb O'Hara]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Author

Created by Caleb O.  
Developed as a an assignment in COMP1026 at St. Lawrence College using concepts learned in Computer Programming & Analysis.
