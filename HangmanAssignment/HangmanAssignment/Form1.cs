using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Text.Json;

namespace HangmanAssignment
{

    // Caleb O'Hara - Hangman Assignment - Form class
    // This program allows you to play hangman with a second player as many times as you want, and 
    // keeps track of scoring and previous game information
    public partial class Form1 : Form
    {
        //Class level variables
        Player playerOne;
        Player playerTwo;
        Scoreboard scoreboardOne;
        Scoreboard highestScore;
        string chosenWord;
        int wordLength;
        char[] chosenWordArray;
        int decidingPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        //When you click the start button, the name page function activates which makes the name page appear
        private void startBtn_Click(object sender, EventArgs e)
        {
            NamePageAppear();
        }

        private void displayHighScoreBtn_Click(object sender, EventArgs e)
        {
            string json;
            json = File.ReadAllText("highscore.json");
            highestScore = JsonSerializer.Deserialize<Scoreboard>(json);
            highestScoreLbl.Text = highestScore.HighestNumbWins;
            highestScoreLbl.Visible = true;
        }

        //When you hit the submit names button, it wil validate the player information and then 
        //Move on to the next page where you choose a word
        private void submitNamesBtn_Click(object sender, EventArgs e)
        {
            ValidatingPlayerInfo();
            InitialInfo();
            ChooseWordPageAppear();
            DecidePlayer();
        }

        //When a word is submitted, the game phase is started and the game can begin!
        private void submitWordBtn_Click(object sender, EventArgs e)
        {
            chosenWord = chooseWordMtx.Text.ToString(); // Puts the chosen word into string "chosen word"
            chosenWord = chosenWord.ToUpper(); // Converts chosen word to uppercase
            chosenWordArray = chosenWord.ToCharArray(); // Creates a char array out of chosen word
            if (chosenWordArray.Length < 3) // If the chosen word is less than 3 letters, user has to retry
            {
                MessageBox.Show("Your word was invalid! Please try again!");
            }
            else
            {
                wordLength = chosenWordArray.Length; // Sets the wordLength (how many characters the word is)
                wordLengthLbl.Text = "Word length is " + wordLength + " characters"; // Displays the word length so the player can see
                GamePageAppear(wordLength); // Game page appears
                MessageBox.Show("Your word is " + chosenWord + " now tell the other player they can look again!");


            }

        }

        // The game phase is now started and the guess button can be clicked!
        private void guessBtn_Click(object sender, EventArgs e)
        {
            bool wordChooserWin;
            bool gameOver = false;
            int index;
            string guess = guessLetterMtx.Text.ToString(); // Converting the letter guess into a string
            guess = guess.ToUpper();
            checkForFailLbl.Text = "fail"; // This hidden label identifies if the user guessed incorrectly, if they guessed correct it will say "not fail"
            if (guess == "")
            {
                MessageBox.Show("Please enter a letter!"); // Guess validation
            }
            else
            {
                for (index = 0; index < wordLength; index++)
                {

                    if (chosenWordArray[index].ToString() == guess) // If the letter was corrected
                    {
                        MessageBox.Show("Correct!"); // Tell the user they guessed correctly
                        CorrectAnswerGuessed(index, guess); // Call correct answer guessed function
                        checkForFailLbl.Text = "no fail"; // Set the fail check label to no fail
                        gameOver = CheckForGuesserWin(wordLength); // Check if that is the end of the game (the last letter guessed)
                        if (gameOver == true) // If that was the end of the game, set wordChooserWin to false (because the guesser won) and call decidingPlayer function
                        {
                            wordChooserWin = false;
                            DecideGameWinner(decidingPlayer, wordChooserWin);

                        }
                    }
                }

                if (checkForFailLbl.Text.ToString() == "fail" && gameOver == false) // If the letter was guessed incorrectly
                {
                    MessageBox.Show("Incorrect!");
                    int numGuesses = Int32.Parse(guessesNumLbl.Text); // Up the number of guesses
                    numGuesses++;
                    AddBodyPart(numGuesses);
                    guessesNumLbl.Text = numGuesses.ToString();
                    if (numGuesses == 6) // If the user has had 6 incorrect guesses, word chooser wins and call decideGameWinner function
                    {
                        wordChooserWin = true;
                        DecideGameWinner(decidingPlayer, wordChooserWin);

                    }
                }

            }

        }


        // FUNCTIONS! (Organized alphabetically)
        // -----------------------------------------------------------------------------------------

        // This function adds a body part to the hangman
        private void AddBodyPart(int numbBodyParts)
        {
            if (numbBodyParts == 1)
            {
                leftFootPbx.Visible = true;
            }
            if (numbBodyParts == 2)
            {
                rightFootPbx.Visible = true;
            }
            if (numbBodyParts == 3)
            {
                torsoPbx.Visible = true;
            }
            if (numbBodyParts == 4)
            {
                leftArmPbx.Visible = true;
            }
            if (numbBodyParts == 5)
            {
                rightArmPbx.Visible = true;
            }
            if (numbBodyParts == 6)
            {
                headPbx.Visible = true;
            }

        }

        // This function brings the players back to the main menu, and will activate if the players choose not to do another round
        private void BackToMenu()
        {
            rightFootPbx.Visible = false;
            leftFootPbx.Visible = false;
            leftArmPbx.Visible = false;
            rightArmPbx.Visible = false;
            headPbx.Visible = false;
            torsoPbx.Visible = false;
            hangThingPbx.Visible = false;
            hangThing2Pbx.Visible = false;
            wordLengthLbl.Visible = false;
            guessesNumLbl.Visible = false;
            guessLetterLbl.Visible = false;
            guessLetterMtx.Visible = false;
            guessesLbl.Visible = false;
            guessBtn.Visible = false;
            correctLetter1Lbl.Visible = false;
            correctLetter2Lbl.Visible = false;
            correctLetter3Lbl.Visible = false;
            correctLetter4Lbl.Visible = false;
            correctLetter5Lbl.Visible = false;
            correctLetter6Lbl.Visible = false;
            startMenuPbx.Visible = true;
            startBtn.Visible = true;
            startBtn.Enabled = true;
            scoreboardLbl.Visible = false;
            player1WinsLbl.Visible = false;
            player2WinsLbl.Visible = false;
            highestNumbWinsLbl.Visible = false;
            previousGameWinnerNameLbl.Visible = false;
            previousGameWordLbl.Visible = false;

        }


        // This function checks if the entire word has been guessed
        private bool CheckForGuesserWin(int wordLength)
        {
            bool gameOver;
            if (wordLength == 3 && (correctLetter1Lbl.Text.ToString() + correctLetter2Lbl.Text.ToString() + correctLetter3Lbl.Text.ToString() == chosenWord))
            {
                gameOver = true;
            }
            else if (wordLength == 4 && (correctLetter1Lbl.Text.ToString() + correctLetter2Lbl.Text.ToString() + correctLetter3Lbl.Text.ToString() + correctLetter4Lbl.Text.ToString() == chosenWord))
            {
                gameOver = true;
            }
            else if (wordLength == 5 && (correctLetter1Lbl.Text.ToString() + correctLetter2Lbl.Text.ToString() + correctLetter3Lbl.Text.ToString() + correctLetter4Lbl.Text.ToString() + correctLetter5Lbl.Text.ToString() == chosenWord))
            {
                gameOver = true;
            }
            else if (wordLength == 6 && (correctLetter1Lbl.Text.ToString() + correctLetter2Lbl.Text.ToString() + correctLetter3Lbl.Text.ToString() + correctLetter4Lbl.Text.ToString() + correctLetter5Lbl.Text.ToString() + correctLetter6Lbl.Text.ToString() == chosenWord))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }

        // This function changes the visibility of elements so the choose word page appears
        private void ChooseWordPageAppear()
        {
            if (highestScoreLbl.Text != "_")
            {
                highestScoreLbl.Visible = true;
                allTimeHighScoreLbl.Visible = true;
            }
            player1Lbl.Visible = false;
            player2Lbl.Visible = false;
            player1NameTxt.Visible = false;
            player2NameTxt.Visible = false;
            submitNamesBtn.Visible = false;
            player2NameTxt.Enabled = false;
            player1NameTxt.Enabled = false;
            player1AgeMtx.Visible = false;
            player1AgeMtx.Enabled = false;
            player1AgeLbl.Visible = false;
            player1NameLbl.Visible = false;
            player2NameLbl.Visible = false;
            player1GenderTxt.Visible = false;
            player1GenderLbl.Visible = false;
            player1GenderTxt.Enabled = false;
            player2NameTxt.Enabled = false;
            player2AgeMtx.Visible = false;
            player2AgeMtx.Enabled = false;
            player2AgeLbl.Visible = false;
            player2GenderTxt.Visible = false;
            player2GenderLbl.Visible = false;
            player2GenderTxt.Enabled = false;
            scoreboardLbl.Visible = true;
            player2WinsLbl.Visible = true;
            player1WinsLbl.Visible = true;
            chooseWordLbl.Visible = true;
            chooseWordMtx.Visible = true;
            rulesLbx.Visible = true;
            submitWordBtn.Visible = true;
            MessageBox.Show("Welcome to Hangman! Here are the rules - Whomever is decided as the word chooser" +
                " will pick a word. Then, the opposite player will have to guess letters in the word! If you get 6 " +
                "incorrect guesses, you lose and the word chooser wins!");
        }



        // This function activates if a correct answer was guessed
        private void CorrectAnswerGuessed(int numb, string letter)
        {
            if (numb == 0 && correctLetter1Lbl.Text.ToString() == "_")
            {
                correctLetter1Lbl.Text = letter;
            }
            else if (numb == 1 && correctLetter2Lbl.Text.ToString() == "_")
            {
                correctLetter2Lbl.Text = letter;
            }
            else if (numb == 2 && correctLetter3Lbl.Text.ToString() == "_")
            {
                correctLetter3Lbl.Text = letter;
            }
            else if (numb == 3 && correctLetter4Lbl.Text.ToString() == "_")
            {
                correctLetter4Lbl.Text = letter;
            }
            else if (numb == 4 && correctLetter5Lbl.Text.ToString() == "_")
            {
                correctLetter5Lbl.Text = letter;
            }
            else if (numb == 5 && correctLetter6Lbl.Text.ToString() == "_")
            {
                correctLetter6Lbl.Text = letter;
            }

        }


        // This function decides who the game winner is based on who was assigned word chooser, and whether or not the word chooser won
        private void DecideGameWinner(int decidingPlayer, bool wordChooserWins)
        {
            if (wordChooserWins == true)
            {
                if (decidingPlayer == 0)
                {
                    PlayerWins(playerOne);
                }
                else
                {
                    PlayerWins(playerTwo);
                }
            }
            else
            {
                checkForFailLbl.Text = "fail";
                if (decidingPlayer == 1)
                {
                    PlayerWins(playerOne);
                }
                else
                {
                    PlayerWins(playerTwo);
                }
            }
        }

        // This function decides which player is the word chooser and which player is the guesser
        private void DecidePlayer()
        {
            Random random = new Random();
            decidingPlayer = random.Next(2);
            if (decidingPlayer == 0)
            {

                MessageBox.Show(playerOne.Name + ", choose a word! Player 2, look away until I say you can look back");
            }
            else
            {
                MessageBox.Show(playerTwo.Name + ", choose a word! Player 1, look away until I say you can look back");
            }
        }



        // This function changes the visibility of elements for the game page to appear
        private void GamePageAppear(int wordLength)
        {
            chooseWordLbl.Visible = false;
            chooseWordMtx.Visible = false;
            rulesLbx.Visible = false;
            submitWordBtn.Visible = false;
            hangThingPbx.Visible = true;
            hangThing2Pbx.Visible = true;
            wordLengthLbl.Visible = true;
            guessesNumLbl.Visible = true;
            guessLetterLbl.Visible = true;
            guessLetterMtx.Visible = true;
            guessesLbl.Visible = true;
            guessBtn.Visible = true;
            correctLetter1Lbl.Visible = true;
            correctLetter2Lbl.Visible = true;
            if (wordLength == 3)
            {
                correctLetter3Lbl.Visible = true;
            }
            else if (wordLength == 4)
            {
                correctLetter3Lbl.Visible = true;
                correctLetter4Lbl.Visible = true;
            }
            else if (wordLength == 5)
            {
                correctLetter3Lbl.Visible = true;
                correctLetter4Lbl.Visible = true;
                correctLetter5Lbl.Visible = true;
            }
            else
            {
                correctLetter3Lbl.Visible = true;
                correctLetter4Lbl.Visible = true;
                correctLetter5Lbl.Visible = true;
                correctLetter6Lbl.Visible = true;
            }
        }

        // This function assigns initial game information to the proper labels
        private void InitialInfo()
        {
            playerOne = new Player(Int32.Parse(player1AgeMtx.Text), player1NameTxt.Text.ToString(), player1GenderTxt.Text.ToString());
            playerTwo = new Player(Int32.Parse(player2AgeMtx.Text), player2NameTxt.Text.ToString(), player2GenderTxt.Text.ToString());
            scoreboardOne = new Scoreboard(player1NameTxt.Text.ToString(), player2NameTxt.Text.ToString());
            player1WinsLbl.Text = (scoreboardOne.Player1Name.ToString() + " - Wins - " + scoreboardOne.Player1Wins);
            player2WinsLbl.Text = (scoreboardOne.Player2Name.ToString() + " - Wins - " + scoreboardOne.Player2Wins);
            previousGameWinnerNameLbl.Text = ("Previous winner - " + scoreboardOne.PreviousGameWinner);
            previousGameWordLbl.Text = ("Previous game word - " + scoreboardOne.PreviousGameWord);
            highestNumbWinsLbl.Text = ("Highest number of wins - " + (scoreboardOne.HighestNumbWins));
            scoreboardOne.Player1Name = player1NameTxt.Text.ToString();
            scoreboardOne.Player2Name = player2NameTxt.Text.ToString();
        }

        // This function changes the appearance of elements so the page for the user to "enter name" appears
        private void NamePageAppear()
        {
            startMenuPbx.Visible = false;
            startBtn.Visible = false;
            startBtn.Enabled = false;
            player1Lbl.Visible = true;
            player2Lbl.Visible = true;
            player1NameTxt.Visible = true;
            player2NameTxt.Visible = true;
            player2NameTxt.Enabled = true;
            player1NameTxt.Enabled = true;
            player1AgeMtx.Visible = true;
            player1AgeMtx.Enabled = true;
            player1AgeLbl.Visible = true;
            player1NameLbl.Visible = true;
            player2NameLbl.Visible = true;
            player1GenderTxt.Visible = true;
            player1GenderLbl.Visible = true;
            player1GenderTxt.Enabled = true;
            player2NameTxt.Enabled = true;
            player2AgeMtx.Visible = true;
            player2AgeMtx.Enabled = true;
            player2AgeLbl.Visible = true;
            player2GenderTxt.Visible = true;
            player2GenderLbl.Visible = true;
            player2GenderTxt.Enabled = true;
            submitNamesBtn.Visible = true;
            bluePbx.Visible = true;
        }


        // This function activates when a player wins, updates the scoreboards accordingly, and asks if the players want to play again
        // Unfortunately I was unable to cut down on the code more due to the nature of "scoreboardOne.Player1Name" vs "scoreboardOne.Player2Name" I 
        // was unable to figure out something I could pass in to differentiate between those two, but I did my best regardless
        private void PlayerWins(Player player)
        {
            DialogResult userResponse;
            string json;

            if (player.Name == scoreboardOne.Player1Name)
            {
                scoreboardOne.Player1Wins++;
                if (scoreboardOne.Player1Wins > scoreboardOne.Player2Wins)
                {
                    scoreboardOne.HighestNumbWins = scoreboardOne.Player1Name;
                    highestNumbWinsLbl.Text = ("Highest number of wins - " + scoreboardOne.HighestNumbWins);
                }
                else if (scoreboardOne.Player1Wins == scoreboardOne.Player2Wins)
                {
                    scoreboardOne.HighestNumbWins = "Tie";
                    highestNumbWinsLbl.Text = ("Highest number of wins - " + scoreboardOne.HighestNumbWins);
                }
                player1WinsLbl.Text = (scoreboardOne.Player1Name + " - Wins - " + scoreboardOne.Player1Wins);
                scoreboardOne.PreviousGameWord = chosenWord;
                previousGameWordLbl.Text = ("Previous game word - " + scoreboardOne.PreviousGameWord);
                scoreboardOne.PreviousGameWinner = scoreboardOne.Player1Name;
                previousGameWinnerNameLbl.Text = ("Previous game winner - " + scoreboardOne.PreviousGameWinner);


                if (highestScore == null)
                {
                    highestScore = new Scoreboard();
                    highestScore.HighestNumbWins = ("Highest number of wins is " + scoreboardOne.Player1Name + " with " + scoreboardOne.Player1Wins + " wins");
                    highestScore.Player1Wins = scoreboardOne.Player1Wins;
                    highestScore.Player2Wins = scoreboardOne.Player2Wins;
                    highestScoreLbl.Text = highestScore.HighestNumbWins;
                    json = JsonSerializer.Serialize(highestScore);
                    File.WriteAllText("highscore.json", json);
                }
                else
                {

                    if (scoreboardOne.Player1Wins > highestScore.Player1Wins && scoreboardOne.Player1Wins > highestScore.Player2Wins && scoreboardOne.Player1Wins > scoreboardOne.Player2Wins)
                    {
                        highestScore.HighestNumbWins = ("Highest number of wins is " + scoreboardOne.Player1Name + " with " + scoreboardOne.Player1Wins + " wins");
                        highestScore.Player1Wins = scoreboardOne.Player1Wins;
                        highestScore.Player2Wins = scoreboardOne.Player2Wins;
                        highestScoreLbl.Text = highestScore.HighestNumbWins;
                        json = JsonSerializer.Serialize(highestScore);
                        File.WriteAllText("highscore.json", json);
                    }
                }

                userResponse = MessageBox.Show(playerOne.Name + " wins! " + "the word was " + chosenWord + ", play again?", "Game Over", MessageBoxButtons.YesNo);
                if (userResponse == DialogResult.Yes)
                {
                    DecidePlayer();
                    StartNewRound();
                }
                else
                {
                    BackToMenu();
                }
            }
            else
            {
                scoreboardOne.Player2Wins++;
                if (scoreboardOne.Player2Wins > scoreboardOne.Player1Wins)
                {
                    scoreboardOne.HighestNumbWins = scoreboardOne.Player2Name;
                    highestNumbWinsLbl.Text = ("Highest number of wins - " + scoreboardOne.HighestNumbWins);
                }
                else if (scoreboardOne.Player1Wins == scoreboardOne.Player2Wins)
                {
                    scoreboardOne.HighestNumbWins = "Tie";
                    highestNumbWinsLbl.Text = ("Highest number of wins - " + scoreboardOne.HighestNumbWins);
                }
                player2WinsLbl.Text = (scoreboardOne.Player2Name + " - Wins - " + scoreboardOne.Player2Wins);
                scoreboardOne.PreviousGameWord = chosenWord;
                previousGameWordLbl.Text = ("Previous game word - " + scoreboardOne.PreviousGameWord);
                scoreboardOne.PreviousGameWinner = scoreboardOne.Player2Name;
                previousGameWinnerNameLbl.Text = ("Previous game winner - " + scoreboardOne.PreviousGameWinner);

                if (highestScore == null)
                {
                    highestScore = new Scoreboard();
                    highestScore.HighestNumbWins = ("Highest number of wins is " + scoreboardOne.Player2Name + " with " + scoreboardOne.Player2Wins + " wins");
                    highestScoreLbl.Text = highestScore.HighestNumbWins;
                    highestScore.Player1Wins = scoreboardOne.Player1Wins;
                    highestScore.Player2Wins = scoreboardOne.Player2Wins;
                    json = JsonSerializer.Serialize(highestScore);
                    File.WriteAllText("highscore.json", json);
                }
                else
                {
                    if (scoreboardOne.Player2Wins > highestScore.Player1Wins && scoreboardOne.Player2Wins > highestScore.Player2Wins && scoreboardOne.Player2Wins > scoreboardOne.Player1Wins)
                    {
                        highestScore.HighestNumbWins = ("Highest number of wins is " + scoreboardOne.Player2Name + " with " + scoreboardOne.Player2Wins + " wins");
                        highestScoreLbl.Text = highestScore.HighestNumbWins;
                        json = JsonSerializer.Serialize(highestScore);
                        File.WriteAllText("highscore.json", json);
                    }
                }

                userResponse = MessageBox.Show(player.Name + " wins! " + "the word was " + chosenWord + ", play again?", "Game Over", MessageBoxButtons.YesNo);
                if (userResponse == DialogResult.Yes)
                {
                    DecidePlayer();
                    StartNewRound();
                }
                else
                {
                    BackToMenu();
                }

            }
        }



        // This function activates if the players choose to start a new round, and converts it to a new round page
        private void StartNewRound()
        {
            correctLetter1Lbl.Visible = false;
            correctLetter2Lbl.Visible = false;
            correctLetter3Lbl.Visible = false;
            correctLetter4Lbl.Visible = false;
            correctLetter5Lbl.Visible = false;
            correctLetter6Lbl.Visible = false;
            correctLetter1Lbl.Text = "_";
            correctLetter2Lbl.Text = "_";
            correctLetter3Lbl.Text = "_";
            correctLetter4Lbl.Text = "_";
            correctLetter5Lbl.Text = "_";
            correctLetter6Lbl.Text = "_";
            rightFootPbx.Visible = false;
            leftFootPbx.Visible = false;
            leftArmPbx.Visible = false;
            rightArmPbx.Visible = false;
            headPbx.Visible = false;
            torsoPbx.Visible = false;
            hangThingPbx.Visible = false;
            hangThing2Pbx.Visible = false;
            wordLengthLbl.Visible = false;
            guessesNumLbl.Text = "0";
            guessesNumLbl.Visible = false;
            guessLetterLbl.Visible = false;
            guessLetterMtx.Visible = false;
            guessesLbl.Visible = false;
            guessBtn.Visible = false;
            chooseWordLbl.Visible = true;
            chooseWordMtx.Visible = true;
            rulesLbx.Visible = true;
            submitWordBtn.Visible = true;
            previousGameWinnerNameLbl.Visible = true;
            previousGameWordLbl.Visible = true;
        }





        // This function essentially puts "undefined" if a user enters their info incorrectly
        private void ValidatingPlayerInfo()
        {
            if (player1NameTxt.Text.ToString() == "")
            {
                player1NameTxt.Text = "Undefined";
            }
            if (player1AgeMtx.Text.ToString() == "")
            {
                player1AgeMtx.Text = "01";
            }
            if (player1GenderTxt.Text.ToString() == "")
            {
                player1GenderTxt.Text = "Undefined";
            }
            if (player2NameTxt.Text.ToString() == "")
            {
                player2NameTxt.Text = "Undefined";
            }
            if (player2AgeMtx.Text.ToString() == "")
            {
                player2AgeMtx.Text = "01";
            }
            if (player2GenderTxt.Text.ToString() == "")
            {
                player2GenderTxt.Text = "Undefined";
            }
        }

    }
}
            
        
    



                
        
    
    

