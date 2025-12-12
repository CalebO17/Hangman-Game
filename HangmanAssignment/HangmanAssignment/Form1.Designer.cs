namespace HangmanAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startMenuPbx = new PictureBox();
            startBtn = new Button();
            player2Lbl = new Label();
            player1Lbl = new Label();
            player1NameTxt = new TextBox();
            bluePbx = new PictureBox();
            submitNamesBtn = new Button();
            chooseWordLbl = new Label();
            chooseWordMtx = new MaskedTextBox();
            rulesLbx = new ListBox();
            submitWordBtn = new Button();
            player1NameLbl = new Label();
            player1GenderTxt = new TextBox();
            player2GenderLbl = new Label();
            player2GenderTxt = new TextBox();
            player2AgeLbl = new Label();
            player2NameLbl = new Label();
            player2NameTxt = new TextBox();
            player1AgeLbl = new Label();
            player1GenderLbl = new Label();
            headPbx = new PictureBox();
            torsoPbx = new PictureBox();
            rightArmPbx = new PictureBox();
            leftArmPbx = new PictureBox();
            leftFootPbx = new PictureBox();
            rightFootPbx = new PictureBox();
            wordLengthLbl = new Label();
            guessesLbl = new Label();
            guessesNumLbl = new Label();
            guessLetterLbl = new Label();
            guessLetterMtx = new MaskedTextBox();
            guessBtn = new Button();
            hangThingPbx = new PictureBox();
            hangThing2Pbx = new PictureBox();
            correctLetter1Lbl = new Label();
            correctLetter2Lbl = new Label();
            correctLetter3Lbl = new Label();
            correctLetter4Lbl = new Label();
            correctLetter5Lbl = new Label();
            correctLetter6Lbl = new Label();
            correctLettersLbl = new Label();
            player2AgeMtx = new MaskedTextBox();
            player1AgeMtx = new MaskedTextBox();
            checkForFailLbl = new LinkLabel();
            scoreboardLbl = new Label();
            numGamesPlayedLbl = new Label();
            label1 = new Label();
            player1WinsLbl = new Label();
            player2WinsLbl = new Label();
            previousGameWinnerNameLbl = new Label();
            previousGameWordLbl = new Label();
            highestNumbWinsLbl = new Label();
            allTimeHighScoreLbl = new Label();
            highestScoreLbl = new Label();
            displayHighScoreBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)startMenuPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bluePbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)headPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)torsoPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArmPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftArmPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftFootPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightFootPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangThingPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangThing2Pbx).BeginInit();
            SuspendLayout();
            // 
            // startMenuPbx
            // 
            startMenuPbx.Image = Properties.Resources.hangman;
            startMenuPbx.Location = new Point(-3, -1);
            startMenuPbx.Name = "startMenuPbx";
            startMenuPbx.Size = new Size(1549, 850);
            startMenuPbx.TabIndex = 0;
            startMenuPbx.TabStop = false;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startBtn.ForeColor = SystemColors.ActiveCaptionText;
            startBtn.Location = new Point(101, 189);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(274, 169);
            startBtn.TabIndex = 1;
            startBtn.Text = "START GAME";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // player2Lbl
            // 
            player2Lbl.AutoSize = true;
            player2Lbl.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2Lbl.Location = new Point(1039, 82);
            player2Lbl.Name = "player2Lbl";
            player2Lbl.Size = new Size(196, 59);
            player2Lbl.TabIndex = 2;
            player2Lbl.Text = "Player 2";
            player2Lbl.Visible = false;
            // 
            // player1Lbl
            // 
            player1Lbl.AutoSize = true;
            player1Lbl.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1Lbl.Location = new Point(211, 82);
            player1Lbl.Name = "player1Lbl";
            player1Lbl.Size = new Size(191, 59);
            player1Lbl.TabIndex = 3;
            player1Lbl.Text = "Player 1";
            player1Lbl.Visible = false;
            // 
            // player1NameTxt
            // 
            player1NameTxt.Enabled = false;
            player1NameTxt.Location = new Point(211, 147);
            player1NameTxt.Name = "player1NameTxt";
            player1NameTxt.Size = new Size(191, 39);
            player1NameTxt.TabIndex = 4;
            player1NameTxt.Visible = false;
            // 
            // bluePbx
            // 
            bluePbx.BackColor = SystemColors.Control;
            bluePbx.BackgroundImage = Properties.Resources.blue;
            bluePbx.BackgroundImageLayout = ImageLayout.Stretch;
            bluePbx.Location = new Point(-3, -1);
            bluePbx.Name = "bluePbx";
            bluePbx.Size = new Size(1549, 850);
            bluePbx.TabIndex = 6;
            bluePbx.TabStop = false;
            bluePbx.Visible = false;
            // 
            // submitNamesBtn
            // 
            submitNamesBtn.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitNamesBtn.Location = new Point(275, 284);
            submitNamesBtn.Name = "submitNamesBtn";
            submitNamesBtn.Size = new Size(961, 335);
            submitNamesBtn.TabIndex = 7;
            submitNamesBtn.Text = "SUBMIT NAMES";
            submitNamesBtn.UseVisualStyleBackColor = true;
            submitNamesBtn.Visible = false;
            submitNamesBtn.Click += submitNamesBtn_Click;
            // 
            // chooseWordLbl
            // 
            chooseWordLbl.AutoSize = true;
            chooseWordLbl.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseWordLbl.Location = new Point(445, 26);
            chooseWordLbl.Name = "chooseWordLbl";
            chooseWordLbl.Size = new Size(588, 66);
            chooseWordLbl.TabIndex = 8;
            chooseWordLbl.Text = "Choose your word!";
            chooseWordLbl.Visible = false;
            // 
            // chooseWordMtx
            // 
            chooseWordMtx.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseWordMtx.Location = new Point(548, 108);
            chooseWordMtx.Mask = "LLL???";
            chooseWordMtx.Name = "chooseWordMtx";
            chooseWordMtx.Size = new Size(377, 78);
            chooseWordMtx.TabIndex = 9;
            chooseWordMtx.Visible = false;
            // 
            // rulesLbx
            // 
            rulesLbx.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rulesLbx.FormattingEnabled = true;
            rulesLbx.ItemHeight = 29;
            rulesLbx.Items.AddRange(new object[] { "1) Words MUST be at least 3 letters ", "2) No more than 6 letters", "3) No innapropriate words", "4) Words must be in English" });
            rulesLbx.Location = new Point(1063, 26);
            rulesLbx.Name = "rulesLbx";
            rulesLbx.SelectionMode = SelectionMode.None;
            rulesLbx.Size = new Size(440, 178);
            rulesLbx.TabIndex = 10;
            rulesLbx.Visible = false;
            // 
            // submitWordBtn
            // 
            submitWordBtn.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitWordBtn.Location = new Point(490, 229);
            submitWordBtn.Name = "submitWordBtn";
            submitWordBtn.Size = new Size(490, 46);
            submitWordBtn.TabIndex = 11;
            submitWordBtn.Text = "Submit Your Word";
            submitWordBtn.UseVisualStyleBackColor = true;
            submitWordBtn.Visible = false;
            submitWordBtn.Click += submitWordBtn_Click;
            // 
            // player1NameLbl
            // 
            player1NameLbl.AutoSize = true;
            player1NameLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1NameLbl.Location = new Point(64, 144);
            player1NameLbl.Name = "player1NameLbl";
            player1NameLbl.Size = new Size(112, 45);
            player1NameLbl.TabIndex = 12;
            player1NameLbl.Text = "Name";
            player1NameLbl.Visible = false;
            // 
            // player1GenderTxt
            // 
            player1GenderTxt.Enabled = false;
            player1GenderTxt.Location = new Point(211, 259);
            player1GenderTxt.Name = "player1GenderTxt";
            player1GenderTxt.Size = new Size(191, 39);
            player1GenderTxt.TabIndex = 15;
            player1GenderTxt.Visible = false;
            // 
            // player2GenderLbl
            // 
            player2GenderLbl.AutoSize = true;
            player2GenderLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2GenderLbl.Location = new Point(1039, 259);
            player2GenderLbl.Name = "player2GenderLbl";
            player2GenderLbl.Size = new Size(134, 45);
            player2GenderLbl.TabIndex = 22;
            player2GenderLbl.Text = "Gender";
            player2GenderLbl.Visible = false;
            // 
            // player2GenderTxt
            // 
            player2GenderTxt.Enabled = false;
            player2GenderTxt.Location = new Point(1179, 259);
            player2GenderTxt.Name = "player2GenderTxt";
            player2GenderTxt.Size = new Size(191, 39);
            player2GenderTxt.TabIndex = 21;
            player2GenderTxt.Visible = false;
            // 
            // player2AgeLbl
            // 
            player2AgeLbl.AutoSize = true;
            player2AgeLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2AgeLbl.Location = new Point(1039, 207);
            player2AgeLbl.Name = "player2AgeLbl";
            player2AgeLbl.Size = new Size(83, 45);
            player2AgeLbl.TabIndex = 20;
            player2AgeLbl.Text = "Age";
            player2AgeLbl.Visible = false;
            // 
            // player2NameLbl
            // 
            player2NameLbl.AutoSize = true;
            player2NameLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2NameLbl.Location = new Point(1039, 150);
            player2NameLbl.Name = "player2NameLbl";
            player2NameLbl.Size = new Size(112, 45);
            player2NameLbl.TabIndex = 18;
            player2NameLbl.Text = "Name";
            player2NameLbl.Visible = false;
            // 
            // player2NameTxt
            // 
            player2NameTxt.Enabled = false;
            player2NameTxt.Location = new Point(1177, 151);
            player2NameTxt.Name = "player2NameTxt";
            player2NameTxt.Size = new Size(191, 39);
            player2NameTxt.TabIndex = 17;
            player2NameTxt.Visible = false;
            // 
            // player1AgeLbl
            // 
            player1AgeLbl.AutoSize = true;
            player1AgeLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1AgeLbl.Location = new Point(64, 201);
            player1AgeLbl.Name = "player1AgeLbl";
            player1AgeLbl.Size = new Size(83, 45);
            player1AgeLbl.TabIndex = 14;
            player1AgeLbl.Text = "Age";
            player1AgeLbl.Visible = false;
            // 
            // player1GenderLbl
            // 
            player1GenderLbl.AutoSize = true;
            player1GenderLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1GenderLbl.Location = new Point(64, 259);
            player1GenderLbl.Name = "player1GenderLbl";
            player1GenderLbl.Size = new Size(134, 45);
            player1GenderLbl.TabIndex = 16;
            player1GenderLbl.Text = "Gender";
            player1GenderLbl.Visible = false;
            // 
            // headPbx
            // 
            headPbx.Image = Properties.Resources.Screenshot_2025_04_12_162628;
            headPbx.Location = new Point(175, 50);
            headPbx.Name = "headPbx";
            headPbx.Size = new Size(200, 165);
            headPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            headPbx.TabIndex = 23;
            headPbx.TabStop = false;
            headPbx.Visible = false;
            // 
            // torsoPbx
            // 
            torsoPbx.Image = Properties.Resources.Screenshot_2025_04_12_162700;
            torsoPbx.Location = new Point(175, 207);
            torsoPbx.Name = "torsoPbx";
            torsoPbx.Size = new Size(200, 245);
            torsoPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            torsoPbx.TabIndex = 24;
            torsoPbx.TabStop = false;
            torsoPbx.Visible = false;
            // 
            // rightArmPbx
            // 
            rightArmPbx.Image = Properties.Resources.Screenshot_2025_04_12_162727;
            rightArmPbx.Location = new Point(367, 170);
            rightArmPbx.Name = "rightArmPbx";
            rightArmPbx.Size = new Size(160, 134);
            rightArmPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            rightArmPbx.TabIndex = 25;
            rightArmPbx.TabStop = false;
            rightArmPbx.Visible = false;
            // 
            // leftArmPbx
            // 
            leftArmPbx.Image = Properties.Resources.Screenshot_2025_04_12_162735;
            leftArmPbx.Location = new Point(6, 181);
            leftArmPbx.Name = "leftArmPbx";
            leftArmPbx.Size = new Size(172, 133);
            leftArmPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            leftArmPbx.TabIndex = 26;
            leftArmPbx.TabStop = false;
            leftArmPbx.Visible = false;
            // 
            // leftFootPbx
            // 
            leftFootPbx.BackColor = Color.FromArgb(0, 162, 232);
            leftFootPbx.Image = Properties.Resources.Screenshot_2025_04_12_162745;
            leftFootPbx.Location = new Point(97, 448);
            leftFootPbx.Name = "leftFootPbx";
            leftFootPbx.Size = new Size(140, 177);
            leftFootPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            leftFootPbx.TabIndex = 27;
            leftFootPbx.TabStop = false;
            leftFootPbx.Visible = false;
            // 
            // rightFootPbx
            // 
            rightFootPbx.Image = Properties.Resources.Screenshot_2025_04_12_162754;
            rightFootPbx.Location = new Point(331, 448);
            rightFootPbx.Name = "rightFootPbx";
            rightFootPbx.Size = new Size(158, 156);
            rightFootPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            rightFootPbx.TabIndex = 28;
            rightFootPbx.TabStop = false;
            rightFootPbx.Visible = false;
            // 
            // wordLengthLbl
            // 
            wordLengthLbl.AutoSize = true;
            wordLengthLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordLengthLbl.Location = new Point(1039, 47);
            wordLengthLbl.Name = "wordLengthLbl";
            wordLengthLbl.Size = new Size(227, 45);
            wordLengthLbl.TabIndex = 30;
            wordLengthLbl.Text = "Word Length";
            wordLengthLbl.UseMnemonic = false;
            wordLengthLbl.Visible = false;
            // 
            // guessesLbl
            // 
            guessesLbl.AutoSize = true;
            guessesLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessesLbl.Location = new Point(1039, 105);
            guessesLbl.Name = "guessesLbl";
            guessesLbl.Size = new Size(458, 45);
            guessesLbl.TabIndex = 31;
            guessesLbl.Text = "Incorrect Guesses (Out of 6)";
            guessesLbl.UseMnemonic = false;
            guessesLbl.Visible = false;
            // 
            // guessesNumLbl
            // 
            guessesNumLbl.AutoSize = true;
            guessesNumLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessesNumLbl.Location = new Point(1242, 159);
            guessesNumLbl.Name = "guessesNumLbl";
            guessesNumLbl.Size = new Size(39, 45);
            guessesNumLbl.TabIndex = 32;
            guessesNumLbl.Text = "0";
            guessesNumLbl.UseMnemonic = false;
            guessesNumLbl.Visible = false;
            // 
            // guessLetterLbl
            // 
            guessLetterLbl.AutoSize = true;
            guessLetterLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessLetterLbl.Location = new Point(1137, 427);
            guessLetterLbl.Name = "guessLetterLbl";
            guessLetterLbl.Size = new Size(245, 45);
            guessLetterLbl.TabIndex = 33;
            guessLetterLbl.Text = "Guess a letter!";
            guessLetterLbl.UseMnemonic = false;
            guessLetterLbl.Visible = false;
            // 
            // guessLetterMtx
            // 
            guessLetterMtx.Location = new Point(1246, 475);
            guessLetterMtx.Mask = "L";
            guessLetterMtx.Name = "guessLetterMtx";
            guessLetterMtx.Size = new Size(20, 39);
            guessLetterMtx.TabIndex = 34;
            guessLetterMtx.Visible = false;
            // 
            // guessBtn
            // 
            guessBtn.Location = new Point(1179, 538);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(150, 46);
            guessBtn.TabIndex = 35;
            guessBtn.Text = "GUESS!!!";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Visible = false;
            guessBtn.Click += guessBtn_Click;
            // 
            // hangThingPbx
            // 
            hangThingPbx.BackColor = Color.FromArgb(0, 162, 232);
            hangThingPbx.Image = Properties.Resources.hangthing3;
            hangThingPbx.Location = new Point(521, 25);
            hangThingPbx.Name = "hangThingPbx";
            hangThingPbx.Size = new Size(512, 824);
            hangThingPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            hangThingPbx.TabIndex = 29;
            hangThingPbx.TabStop = false;
            hangThingPbx.Visible = false;
            // 
            // hangThing2Pbx
            // 
            hangThing2Pbx.Image = Properties.Resources.Screenshot_2025_04_12_1856402;
            hangThing2Pbx.Location = new Point(245, 26);
            hangThing2Pbx.Name = "hangThing2Pbx";
            hangThing2Pbx.Size = new Size(529, 10);
            hangThing2Pbx.SizeMode = PictureBoxSizeMode.StretchImage;
            hangThing2Pbx.TabIndex = 36;
            hangThing2Pbx.TabStop = false;
            hangThing2Pbx.Visible = false;
            // 
            // correctLetter1Lbl
            // 
            correctLetter1Lbl.AutoSize = true;
            correctLetter1Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter1Lbl.Location = new Point(1063, 704);
            correctLetter1Lbl.Name = "correctLetter1Lbl";
            correctLetter1Lbl.Size = new Size(43, 59);
            correctLetter1Lbl.TabIndex = 37;
            correctLetter1Lbl.Text = "_";
            correctLetter1Lbl.Visible = false;
            // 
            // correctLetter2Lbl
            // 
            correctLetter2Lbl.AutoSize = true;
            correctLetter2Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter2Lbl.Location = new Point(1137, 704);
            correctLetter2Lbl.Name = "correctLetter2Lbl";
            correctLetter2Lbl.Size = new Size(43, 59);
            correctLetter2Lbl.TabIndex = 38;
            correctLetter2Lbl.Text = "_";
            correctLetter2Lbl.Visible = false;
            // 
            // correctLetter3Lbl
            // 
            correctLetter3Lbl.AutoSize = true;
            correctLetter3Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter3Lbl.Location = new Point(1216, 704);
            correctLetter3Lbl.Name = "correctLetter3Lbl";
            correctLetter3Lbl.Size = new Size(43, 59);
            correctLetter3Lbl.TabIndex = 39;
            correctLetter3Lbl.Text = "_";
            correctLetter3Lbl.Visible = false;
            // 
            // correctLetter4Lbl
            // 
            correctLetter4Lbl.AutoSize = true;
            correctLetter4Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter4Lbl.Location = new Point(1286, 704);
            correctLetter4Lbl.Name = "correctLetter4Lbl";
            correctLetter4Lbl.Size = new Size(43, 59);
            correctLetter4Lbl.TabIndex = 40;
            correctLetter4Lbl.Text = "_";
            correctLetter4Lbl.Visible = false;
            // 
            // correctLetter5Lbl
            // 
            correctLetter5Lbl.AutoSize = true;
            correctLetter5Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter5Lbl.Location = new Point(1363, 704);
            correctLetter5Lbl.Name = "correctLetter5Lbl";
            correctLetter5Lbl.Size = new Size(43, 59);
            correctLetter5Lbl.TabIndex = 41;
            correctLetter5Lbl.Text = "_";
            correctLetter5Lbl.Visible = false;
            // 
            // correctLetter6Lbl
            // 
            correctLetter6Lbl.AutoSize = true;
            correctLetter6Lbl.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctLetter6Lbl.Location = new Point(1435, 704);
            correctLetter6Lbl.Name = "correctLetter6Lbl";
            correctLetter6Lbl.Size = new Size(43, 59);
            correctLetter6Lbl.TabIndex = 42;
            correctLetter6Lbl.Text = "_";
            correctLetter6Lbl.Visible = false;
            // 
            // correctLettersLbl
            // 
            correctLettersLbl.AutoSize = true;
            correctLettersLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            correctLettersLbl.Location = new Point(1130, 622);
            correctLettersLbl.Name = "correctLettersLbl";
            correctLettersLbl.Size = new Size(252, 45);
            correctLettersLbl.TabIndex = 43;
            correctLettersLbl.Text = "Correct Letters";
            correctLettersLbl.UseMnemonic = false;
            correctLettersLbl.Visible = false;
            // 
            // player2AgeMtx
            // 
            player2AgeMtx.Location = new Point(1251, 210);
            player2AgeMtx.Mask = "00";
            player2AgeMtx.Name = "player2AgeMtx";
            player2AgeMtx.Size = new Size(30, 39);
            player2AgeMtx.TabIndex = 44;
            player2AgeMtx.ValidatingType = typeof(int);
            player2AgeMtx.Visible = false;
            // 
            // player1AgeMtx
            // 
            player1AgeMtx.Location = new Point(288, 201);
            player1AgeMtx.Mask = "00";
            player1AgeMtx.Name = "player1AgeMtx";
            player1AgeMtx.Size = new Size(38, 39);
            player1AgeMtx.TabIndex = 45;
            player1AgeMtx.Visible = false;
            // 
            // checkForFailLbl
            // 
            checkForFailLbl.AutoSize = true;
            checkForFailLbl.Location = new Point(-3, -1);
            checkForFailLbl.Name = "checkForFailLbl";
            checkForFailLbl.Size = new Size(46, 32);
            checkForFailLbl.TabIndex = 46;
            checkForFailLbl.TabStop = true;
            checkForFailLbl.Text = "fail";
            checkForFailLbl.Visible = false;
            // 
            // scoreboardLbl
            // 
            scoreboardLbl.AutoSize = true;
            scoreboardLbl.Location = new Point(27, 651);
            scoreboardLbl.Name = "scoreboardLbl";
            scoreboardLbl.Size = new Size(135, 32);
            scoreboardLbl.TabIndex = 47;
            scoreboardLbl.Text = "Scoreboard";
            scoreboardLbl.Visible = false;
            // 
            // numGamesPlayedLbl
            // 
            numGamesPlayedLbl.AutoSize = true;
            numGamesPlayedLbl.Location = new Point(375, 704);
            numGamesPlayedLbl.Name = "numGamesPlayedLbl";
            numGamesPlayedLbl.Size = new Size(0, 32);
            numGamesPlayedLbl.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 736);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 50;
            // 
            // player1WinsLbl
            // 
            player1WinsLbl.AutoSize = true;
            player1WinsLbl.Location = new Point(-3, 683);
            player1WinsLbl.Name = "player1WinsLbl";
            player1WinsLbl.Size = new Size(24, 32);
            player1WinsLbl.TabIndex = 51;
            player1WinsLbl.Text = "_";
            player1WinsLbl.Visible = false;
            // 
            // player2WinsLbl
            // 
            player2WinsLbl.AutoSize = true;
            player2WinsLbl.Location = new Point(-3, 715);
            player2WinsLbl.Name = "player2WinsLbl";
            player2WinsLbl.Size = new Size(24, 32);
            player2WinsLbl.TabIndex = 52;
            player2WinsLbl.Text = "_";
            player2WinsLbl.Visible = false;
            // 
            // previousGameWinnerNameLbl
            // 
            previousGameWinnerNameLbl.AutoSize = true;
            previousGameWinnerNameLbl.Location = new Point(-3, 748);
            previousGameWinnerNameLbl.Name = "previousGameWinnerNameLbl";
            previousGameWinnerNameLbl.Size = new Size(24, 32);
            previousGameWinnerNameLbl.TabIndex = 56;
            previousGameWinnerNameLbl.Text = "_";
            previousGameWinnerNameLbl.Visible = false;
            // 
            // previousGameWordLbl
            // 
            previousGameWordLbl.AutoSize = true;
            previousGameWordLbl.Location = new Point(-3, 779);
            previousGameWordLbl.Name = "previousGameWordLbl";
            previousGameWordLbl.Size = new Size(24, 32);
            previousGameWordLbl.TabIndex = 57;
            previousGameWordLbl.Text = "_";
            previousGameWordLbl.Visible = false;
            // 
            // highestNumbWinsLbl
            // 
            highestNumbWinsLbl.AutoSize = true;
            highestNumbWinsLbl.Location = new Point(-3, 811);
            highestNumbWinsLbl.Name = "highestNumbWinsLbl";
            highestNumbWinsLbl.Size = new Size(24, 32);
            highestNumbWinsLbl.TabIndex = 59;
            highestNumbWinsLbl.Text = "_";
            highestNumbWinsLbl.Visible = false;
            // 
            // allTimeHighScoreLbl
            // 
            allTimeHighScoreLbl.AutoSize = true;
            allTimeHighScoreLbl.Location = new Point(288, 632);
            allTimeHighScoreLbl.Name = "allTimeHighScoreLbl";
            allTimeHighScoreLbl.Size = new Size(131, 32);
            allTimeHighScoreLbl.TabIndex = 60;
            allTimeHighScoreLbl.Text = "High Score";
            allTimeHighScoreLbl.Visible = false;
            // 
            // highestScoreLbl
            // 
            highestScoreLbl.AutoSize = true;
            highestScoreLbl.Location = new Point(275, 664);
            highestScoreLbl.Name = "highestScoreLbl";
            highestScoreLbl.Size = new Size(24, 32);
            highestScoreLbl.TabIndex = 61;
            highestScoreLbl.Text = "_";
            highestScoreLbl.Visible = false;
            // 
            // displayHighScoreBtn
            // 
            displayHighScoreBtn.Location = new Point(1130, 788);
            displayHighScoreBtn.Name = "displayHighScoreBtn";
            displayHighScoreBtn.Size = new Size(299, 46);
            displayHighScoreBtn.TabIndex = 62;
            displayHighScoreBtn.Text = "Display High Score";
            displayHighScoreBtn.UseVisualStyleBackColor = true;
            displayHighScoreBtn.Click += displayHighScoreBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 846);
            Controls.Add(displayHighScoreBtn);
            Controls.Add(highestScoreLbl);
            Controls.Add(allTimeHighScoreLbl);
            Controls.Add(highestNumbWinsLbl);
            Controls.Add(previousGameWordLbl);
            Controls.Add(previousGameWinnerNameLbl);
            Controls.Add(player2WinsLbl);
            Controls.Add(player1WinsLbl);
            Controls.Add(label1);
            Controls.Add(numGamesPlayedLbl);
            Controls.Add(scoreboardLbl);
            Controls.Add(checkForFailLbl);
            Controls.Add(player1AgeMtx);
            Controls.Add(player2AgeMtx);
            Controls.Add(correctLettersLbl);
            Controls.Add(correctLetter6Lbl);
            Controls.Add(correctLetter5Lbl);
            Controls.Add(correctLetter4Lbl);
            Controls.Add(correctLetter3Lbl);
            Controls.Add(correctLetter2Lbl);
            Controls.Add(correctLetter1Lbl);
            Controls.Add(hangThing2Pbx);
            Controls.Add(leftArmPbx);
            Controls.Add(headPbx);
            Controls.Add(rightArmPbx);
            Controls.Add(torsoPbx);
            Controls.Add(rightFootPbx);
            Controls.Add(leftFootPbx);
            Controls.Add(guessBtn);
            Controls.Add(guessLetterLbl);
            Controls.Add(guessLetterMtx);
            Controls.Add(guessesNumLbl);
            Controls.Add(guessesLbl);
            Controls.Add(wordLengthLbl);
            Controls.Add(hangThingPbx);
            Controls.Add(player2GenderLbl);
            Controls.Add(player2GenderTxt);
            Controls.Add(player2AgeLbl);
            Controls.Add(player2NameLbl);
            Controls.Add(player2NameTxt);
            Controls.Add(player1GenderLbl);
            Controls.Add(player1GenderTxt);
            Controls.Add(player1AgeLbl);
            Controls.Add(player1NameLbl);
            Controls.Add(submitWordBtn);
            Controls.Add(rulesLbx);
            Controls.Add(chooseWordMtx);
            Controls.Add(chooseWordLbl);
            Controls.Add(submitNamesBtn);
            Controls.Add(player1NameTxt);
            Controls.Add(player1Lbl);
            Controls.Add(player2Lbl);
            Controls.Add(startBtn);
            Controls.Add(startMenuPbx);
            Controls.Add(bluePbx);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)startMenuPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)bluePbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)headPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)torsoPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArmPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftArmPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftFootPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightFootPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangThingPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangThing2Pbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox startMenuPbx;
        private Button startBtn;
        private Label player2Lbl;
        private Label player1Lbl;
        private TextBox player1NameTxt;
        private PictureBox bluePbx;
        private Button submitNamesBtn;
        private Label chooseWordLbl;
        private MaskedTextBox chooseWordMtx;
        private ListBox rulesLbx;
        private Button submitWordBtn;
        private Label player1NameLbl;
        private TextBox player1AgeTxt;
        private TextBox player1GenderTxt;
        private Label player2GenderLbl;
        private TextBox player2GenderTxt;
        private Label player2AgeLbl;
        private Label player2NameLbl;
        private TextBox player2NameTxt;
        private Label player1AgeLbl;
        private Label player1GenderLbl;
        private PictureBox headPbx;
        private PictureBox torsoPbx;
        private PictureBox rightArmPbx;
        private PictureBox leftArmPbx;
        private PictureBox leftFootPbx;
        private PictureBox rightFootPbx;
        private Label wordLengthLbl;
        private Label guessesLbl;
        private Label guessesNumLbl;
        private Label guessLetterLbl;
        private MaskedTextBox guessLetterMtx;
        private Button guessBtn;
        private PictureBox hangThingPbx;
        private PictureBox hangThing2Pbx;
        private Label correctLetter1Lbl;
        private Label correctLetter2Lbl;
        private Label correctLetter3Lbl;
        private Label correctLetter4Lbl;
        private Label correctLetter5Lbl;
        private Label correctLetter6Lbl;
        private Label correctLettersLbl;
        private MaskedTextBox player2AgeMtx;
        private MaskedTextBox player1AgeMtx;
        private LinkLabel checkForFailLbl;
        private Label scoreboardLbl;
        private Label numGamesPlayedLbl;
        private Label label1;
        private Label player1WinsLbl;
        private Label player2WinsLbl;
        private Label previousGameWinnerNameLbl;
        private Label previousGameWordLbl;
        private Label highestNumbWinsLbl;
        private Label allTimeHighScoreLbl;
        private Label highestScoreLbl;
        private Button displayHighScoreBtn;
    }
}
