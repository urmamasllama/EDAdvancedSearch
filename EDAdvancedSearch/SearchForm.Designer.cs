namespace EDAdvancedSearch
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFaction = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxPMax = new EDAdvancedSearch.NumericTextBox();
            this.textBoxPMin = new EDAdvancedSearch.NumericTextBox();
            this.advComboPer = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboPos = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboPow = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboEco = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboSec = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboAll = new EDAdvancedSearch.AdvancedComboBox();
            this.advComboGov = new EDAdvancedSearch.AdvancedComboBox();
            this.numericBoxR = new EDAdvancedSearch.NumericTextBox();
            this.numericBoxZ = new EDAdvancedSearch.NumericTextBox();
            this.numericBoxY = new EDAdvancedSearch.NumericTextBox();
            this.numericBoxX = new EDAdvancedSearch.NumericTextBox();
            this.checkCrd = new System.Windows.Forms.CheckBox();
            this.checkFac = new System.Windows.Forms.CheckBox();
            this.checkPop = new System.Windows.Forms.CheckBox();
            this.checkGov = new System.Windows.Forms.CheckBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.checkSec = new System.Windows.Forms.CheckBox();
            this.checkEco = new System.Windows.Forms.CheckBox();
            this.checkPow = new System.Windows.Forms.CheckBox();
            this.checkPos = new System.Windows.Forms.CheckBox();
            this.checkPer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.BackColor = System.Drawing.Color.Black;
            this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConsoleTextBox.Location = new System.Drawing.Point(336, 12);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(423, 446);
            this.ConsoleTextBox.TabIndex = 0;
            this.ConsoleTextBox.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Black;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(317, 21);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "System Name";
            this.textBoxName.DoubleClick += new System.EventHandler(this.textBoxName_DoubleClick);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxFaction
            // 
            this.textBoxFaction.BackColor = System.Drawing.Color.Black;
            this.textBoxFaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxFaction.Location = new System.Drawing.Point(12, 66);
            this.textBoxFaction.Name = "textBoxFaction";
            this.textBoxFaction.ReadOnly = true;
            this.textBoxFaction.Size = new System.Drawing.Size(317, 21);
            this.textBoxFaction.TabIndex = 6;
            this.textBoxFaction.Text = "Faction Name";
            this.textBoxFaction.DoubleClick += new System.EventHandler(this.textBoxFaction_DoubleClick);
            this.textBoxFaction.Enter += new System.EventHandler(this.textBoxFaction_Enter);
            this.textBoxFaction.Leave += new System.EventHandler(this.textBoxFaction_Leave);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(12, 386);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(155, 33);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(175, 425);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(154, 33);
            this.buttonHelp.TabIndex = 18;
            this.buttonHelp.Text = "HELP";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(12, 425);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(155, 33);
            this.buttonQuit.TabIndex = 19;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(175, 386);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(154, 33);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxPMax
            // 
            this.textBoxPMax.AllowSpace = false;
            this.textBoxPMax.BackColor = System.Drawing.Color.Black;
            this.textBoxPMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPMax.Location = new System.Drawing.Point(174, 93);
            this.textBoxPMax.Name = "textBoxPMax";
            this.textBoxPMax.ReadOnly = true;
            this.textBoxPMax.Size = new System.Drawing.Size(155, 21);
            this.textBoxPMax.TabIndex = 8;
            this.textBoxPMax.Text = "Population Max";
            this.textBoxPMax.DoubleClick += new System.EventHandler(this.textBoxPMax_DoubleClick);
            this.textBoxPMax.Enter += new System.EventHandler(this.textBoxPMax_Enter);
            this.textBoxPMax.Leave += new System.EventHandler(this.textBoxPMax_Leave);
            // 
            // textBoxPMin
            // 
            this.textBoxPMin.AllowSpace = false;
            this.textBoxPMin.BackColor = System.Drawing.Color.Black;
            this.textBoxPMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxPMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPMin.Location = new System.Drawing.Point(12, 93);
            this.textBoxPMin.Name = "textBoxPMin";
            this.textBoxPMin.ReadOnly = true;
            this.textBoxPMin.Size = new System.Drawing.Size(155, 21);
            this.textBoxPMin.TabIndex = 7;
            this.textBoxPMin.Text = "Population Min";
            this.textBoxPMin.DoubleClick += new System.EventHandler(this.textBoxPMin_DoubleClick);
            this.textBoxPMin.Enter += new System.EventHandler(this.textBoxPMin_Enter);
            this.textBoxPMin.Leave += new System.EventHandler(this.textBoxPMin_Leave);
            // 
            // advComboPer
            // 
            this.advComboPer.BackColor = System.Drawing.Color.Black;
            this.advComboPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboPer.FormattingEnabled = true;
            this.advComboPer.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboPer.Location = new System.Drawing.Point(12, 204);
            this.advComboPer.Name = "advComboPer";
            this.advComboPer.Size = new System.Drawing.Size(155, 22);
            this.advComboPer.TabIndex = 15;
            this.advComboPer.DropDownClosed += new System.EventHandler(this.advComboPer_DropDownClosed);
            // 
            // advComboPos
            // 
            this.advComboPos.BackColor = System.Drawing.Color.Black;
            this.advComboPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboPos.FormattingEnabled = true;
            this.advComboPos.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboPos.Location = new System.Drawing.Point(175, 176);
            this.advComboPos.Name = "advComboPos";
            this.advComboPos.Size = new System.Drawing.Size(155, 22);
            this.advComboPos.TabIndex = 14;
            this.advComboPos.DropDownClosed += new System.EventHandler(this.advComboPos_DropDownClosed);
            // 
            // advComboPow
            // 
            this.advComboPow.BackColor = System.Drawing.Color.Black;
            this.advComboPow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboPow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboPow.FormattingEnabled = true;
            this.advComboPow.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboPow.Location = new System.Drawing.Point(12, 176);
            this.advComboPow.Name = "advComboPow";
            this.advComboPow.Size = new System.Drawing.Size(155, 22);
            this.advComboPow.TabIndex = 13;
            this.advComboPow.DropDownClosed += new System.EventHandler(this.advComboPow_DropDownClosed);
            // 
            // advComboEco
            // 
            this.advComboEco.BackColor = System.Drawing.Color.Black;
            this.advComboEco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboEco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboEco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboEco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboEco.FormattingEnabled = true;
            this.advComboEco.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboEco.Location = new System.Drawing.Point(175, 148);
            this.advComboEco.Name = "advComboEco";
            this.advComboEco.Size = new System.Drawing.Size(155, 22);
            this.advComboEco.TabIndex = 12;
            this.advComboEco.DropDownClosed += new System.EventHandler(this.advComboEco_DropDownClosed);
            // 
            // advComboSec
            // 
            this.advComboSec.BackColor = System.Drawing.Color.Black;
            this.advComboSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboSec.FormattingEnabled = true;
            this.advComboSec.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboSec.Location = new System.Drawing.Point(12, 148);
            this.advComboSec.Name = "advComboSec";
            this.advComboSec.Size = new System.Drawing.Size(155, 22);
            this.advComboSec.TabIndex = 11;
            this.advComboSec.DropDownClosed += new System.EventHandler(this.advComboSec_DropDownClosed);
            // 
            // advComboAll
            // 
            this.advComboAll.BackColor = System.Drawing.Color.Black;
            this.advComboAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboAll.FormattingEnabled = true;
            this.advComboAll.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboAll.Location = new System.Drawing.Point(175, 120);
            this.advComboAll.Name = "advComboAll";
            this.advComboAll.Size = new System.Drawing.Size(155, 22);
            this.advComboAll.TabIndex = 10;
            this.advComboAll.DropDownClosed += new System.EventHandler(this.advComboAll_DropDownClosed);
            // 
            // advComboGov
            // 
            this.advComboGov.BackColor = System.Drawing.Color.Black;
            this.advComboGov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advComboGov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advComboGov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advComboGov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advComboGov.FormattingEnabled = true;
            this.advComboGov.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.advComboGov.Location = new System.Drawing.Point(12, 120);
            this.advComboGov.Name = "advComboGov";
            this.advComboGov.Size = new System.Drawing.Size(155, 22);
            this.advComboGov.TabIndex = 9;
            this.advComboGov.DropDownClosed += new System.EventHandler(this.advComboGov_DropDownClosed);
            // 
            // numericBoxR
            // 
            this.numericBoxR.AllowSpace = false;
            this.numericBoxR.BackColor = System.Drawing.Color.Black;
            this.numericBoxR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numericBoxR.Location = new System.Drawing.Point(255, 39);
            this.numericBoxR.Name = "numericBoxR";
            this.numericBoxR.ReadOnly = true;
            this.numericBoxR.Size = new System.Drawing.Size(74, 21);
            this.numericBoxR.TabIndex = 5;
            this.numericBoxR.Text = "Radius";
            this.numericBoxR.DoubleClick += new System.EventHandler(this.numericBoxR_DoubleClick);
            this.numericBoxR.Enter += new System.EventHandler(this.numericBoxR_Enter);
            this.numericBoxR.Leave += new System.EventHandler(this.numericBoxR_Leave);
            // 
            // numericBoxZ
            // 
            this.numericBoxZ.AllowSpace = false;
            this.numericBoxZ.BackColor = System.Drawing.Color.Black;
            this.numericBoxZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBoxZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numericBoxZ.Location = new System.Drawing.Point(174, 39);
            this.numericBoxZ.Name = "numericBoxZ";
            this.numericBoxZ.ReadOnly = true;
            this.numericBoxZ.Size = new System.Drawing.Size(75, 21);
            this.numericBoxZ.TabIndex = 4;
            this.numericBoxZ.Text = "Z Coordinate";
            this.numericBoxZ.DoubleClick += new System.EventHandler(this.numericBoxZ_DoubleClick);
            this.numericBoxZ.Enter += new System.EventHandler(this.numericBoxZ_Enter);
            this.numericBoxZ.Leave += new System.EventHandler(this.numericBoxZ_Leave);
            // 
            // numericBoxY
            // 
            this.numericBoxY.AllowSpace = false;
            this.numericBoxY.BackColor = System.Drawing.Color.Black;
            this.numericBoxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBoxY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numericBoxY.Location = new System.Drawing.Point(93, 39);
            this.numericBoxY.Name = "numericBoxY";
            this.numericBoxY.ReadOnly = true;
            this.numericBoxY.Size = new System.Drawing.Size(75, 21);
            this.numericBoxY.TabIndex = 3;
            this.numericBoxY.Text = "Y Coordinate";
            this.numericBoxY.DoubleClick += new System.EventHandler(this.numericBoxY_DoubleClick);
            this.numericBoxY.Enter += new System.EventHandler(this.numericBoxY_Enter);
            this.numericBoxY.Leave += new System.EventHandler(this.numericBoxY_Leave);
            // 
            // numericBoxX
            // 
            this.numericBoxX.AllowSpace = false;
            this.numericBoxX.BackColor = System.Drawing.Color.Black;
            this.numericBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numericBoxX.Location = new System.Drawing.Point(12, 39);
            this.numericBoxX.Name = "numericBoxX";
            this.numericBoxX.ReadOnly = true;
            this.numericBoxX.Size = new System.Drawing.Size(75, 21);
            this.numericBoxX.TabIndex = 2;
            this.numericBoxX.Text = "X Coordinate";
            this.numericBoxX.DoubleClick += new System.EventHandler(this.numericBoxX_DoubleClick);
            this.numericBoxX.Enter += new System.EventHandler(this.numericBoxX_Enter);
            this.numericBoxX.Leave += new System.EventHandler(this.numericBoxX_Leave);
            // 
            // checkCrd
            // 
            this.checkCrd.AutoSize = true;
            this.checkCrd.BackColor = System.Drawing.Color.Black;
            this.checkCrd.Checked = true;
            this.checkCrd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkCrd.Location = new System.Drawing.Point(12, 233);
            this.checkCrd.Name = "checkCrd";
            this.checkCrd.Size = new System.Drawing.Size(89, 19);
            this.checkCrd.TabIndex = 20;
            this.checkCrd.Text = "Coordinates";
            this.checkCrd.UseVisualStyleBackColor = false;
            // 
            // checkFac
            // 
            this.checkFac.AutoSize = true;
            this.checkFac.BackColor = System.Drawing.Color.Black;
            this.checkFac.Checked = true;
            this.checkFac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkFac.Location = new System.Drawing.Point(12, 283);
            this.checkFac.Name = "checkFac";
            this.checkFac.Size = new System.Drawing.Size(63, 19);
            this.checkFac.TabIndex = 21;
            this.checkFac.Text = "Faction";
            this.checkFac.UseVisualStyleBackColor = false;
            // 
            // checkPop
            // 
            this.checkPop.AutoSize = true;
            this.checkPop.BackColor = System.Drawing.Color.Black;
            this.checkPop.Checked = true;
            this.checkPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkPop.Location = new System.Drawing.Point(12, 258);
            this.checkPop.Name = "checkPop";
            this.checkPop.Size = new System.Drawing.Size(88, 19);
            this.checkPop.TabIndex = 22;
            this.checkPop.Text = "Population  ";
            this.checkPop.UseVisualStyleBackColor = false;
            // 
            // checkGov
            // 
            this.checkGov.AutoSize = true;
            this.checkGov.BackColor = System.Drawing.Color.Black;
            this.checkGov.Checked = true;
            this.checkGov.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkGov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkGov.Location = new System.Drawing.Point(12, 308);
            this.checkGov.Name = "checkGov";
            this.checkGov.Size = new System.Drawing.Size(90, 19);
            this.checkGov.TabIndex = 23;
            this.checkGov.Text = "Government";
            this.checkGov.UseVisualStyleBackColor = false;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.BackColor = System.Drawing.Color.Black;
            this.checkAll.Checked = true;
            this.checkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkAll.Location = new System.Drawing.Point(12, 333);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(80, 19);
            this.checkAll.TabIndex = 24;
            this.checkAll.Text = "Allegiance";
            this.checkAll.UseVisualStyleBackColor = false;
            // 
            // checkSec
            // 
            this.checkSec.AutoSize = true;
            this.checkSec.BackColor = System.Drawing.Color.Black;
            this.checkSec.Checked = true;
            this.checkSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkSec.Location = new System.Drawing.Point(107, 233);
            this.checkSec.Name = "checkSec";
            this.checkSec.Size = new System.Drawing.Size(66, 19);
            this.checkSec.TabIndex = 25;
            this.checkSec.Text = "Security";
            this.checkSec.UseVisualStyleBackColor = false;
            // 
            // checkEco
            // 
            this.checkEco.AutoSize = true;
            this.checkEco.BackColor = System.Drawing.Color.Black;
            this.checkEco.Checked = true;
            this.checkEco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkEco.Location = new System.Drawing.Point(107, 258);
            this.checkEco.Name = "checkEco";
            this.checkEco.Size = new System.Drawing.Size(74, 19);
            this.checkEco.TabIndex = 26;
            this.checkEco.Text = "Economy";
            this.checkEco.UseVisualStyleBackColor = false;
            // 
            // checkPow
            // 
            this.checkPow.AutoSize = true;
            this.checkPow.BackColor = System.Drawing.Color.Black;
            this.checkPow.Checked = true;
            this.checkPow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkPow.Location = new System.Drawing.Point(107, 283);
            this.checkPow.Name = "checkPow";
            this.checkPow.Size = new System.Drawing.Size(58, 19);
            this.checkPow.TabIndex = 27;
            this.checkPow.Text = "Power";
            this.checkPow.UseVisualStyleBackColor = false;
            // 
            // checkPos
            // 
            this.checkPos.AutoSize = true;
            this.checkPos.BackColor = System.Drawing.Color.Black;
            this.checkPos.Checked = true;
            this.checkPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkPos.Location = new System.Drawing.Point(107, 308);
            this.checkPos.Name = "checkPos";
            this.checkPos.Size = new System.Drawing.Size(89, 19);
            this.checkPos.TabIndex = 28;
            this.checkPos.Text = "Power State";
            this.checkPos.UseVisualStyleBackColor = false;
            // 
            // checkPer
            // 
            this.checkPer.AutoSize = true;
            this.checkPer.BackColor = System.Drawing.Color.Black;
            this.checkPer.Checked = true;
            this.checkPer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkPer.Location = new System.Drawing.Point(107, 333);
            this.checkPer.Name = "checkPer";
            this.checkPer.Size = new System.Drawing.Size(98, 19);
            this.checkPer.TabIndex = 29;
            this.checkPer.Text = "Needs Permit";
            this.checkPer.UseVisualStyleBackColor = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 470);
            this.Controls.Add(this.checkPer);
            this.Controls.Add(this.checkPos);
            this.Controls.Add(this.checkPow);
            this.Controls.Add(this.checkEco);
            this.Controls.Add(this.checkSec);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.checkGov);
            this.Controls.Add(this.checkPop);
            this.Controls.Add(this.checkFac);
            this.Controls.Add(this.checkCrd);
            this.Controls.Add(this.textBoxPMax);
            this.Controls.Add(this.textBoxPMin);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.advComboPer);
            this.Controls.Add(this.advComboPos);
            this.Controls.Add(this.advComboPow);
            this.Controls.Add(this.advComboEco);
            this.Controls.Add(this.advComboSec);
            this.Controls.Add(this.advComboAll);
            this.Controls.Add(this.advComboGov);
            this.Controls.Add(this.textBoxFaction);
            this.Controls.Add(this.numericBoxR);
            this.Controls.Add(this.numericBoxZ);
            this.Controls.Add(this.numericBoxY);
            this.Controls.Add(this.numericBoxX);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ConsoleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.Text = "E:D Advanced Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.Shown += new System.EventHandler(this.SearchForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.TextBox textBoxName;
        private NumericTextBox numericBoxX;
        private NumericTextBox numericBoxY;
        private NumericTextBox numericBoxZ;
        private NumericTextBox numericBoxR;
        private System.Windows.Forms.TextBox textBoxFaction;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AdvancedComboBox advComboGov;
        private AdvancedComboBox advComboAll;
        private AdvancedComboBox advComboSec;
        private AdvancedComboBox advComboEco;
        private AdvancedComboBox advComboPow;
        private AdvancedComboBox advComboPos;
        private AdvancedComboBox advComboPer;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSearch;
        private NumericTextBox textBoxPMin;
        private NumericTextBox textBoxPMax;
        private System.Windows.Forms.CheckBox checkCrd;
        private System.Windows.Forms.CheckBox checkFac;
        private System.Windows.Forms.CheckBox checkPop;
        private System.Windows.Forms.CheckBox checkGov;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.CheckBox checkSec;
        private System.Windows.Forms.CheckBox checkEco;
        private System.Windows.Forms.CheckBox checkPow;
        private System.Windows.Forms.CheckBox checkPos;
        private System.Windows.Forms.CheckBox checkPer;
    }
}

